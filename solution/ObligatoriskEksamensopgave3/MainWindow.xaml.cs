using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;

namespace ObligatoriskEksamensopgave3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Instansvariabler
        private IPizza pizza;
        private string pizzaType;
        private List<string> extrasList;
        private IPizzaFactory pizza_factory;
        private List<IPizza> PizzaList;
        

        public MainWindow()
        {
            InitializeComponent();

            //En factory instantieres
            //Havde man flere factories skulle den rette
            //instantieres et senere sted i koden
            pizza_factory = new OrdinaryPizzaFactory();

        }

        //Eventhandlers
        //Pizzatyper sættes
        private void PepperoniPizzaGroupBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pizzaType = "Pepperoni";

            //ResetUI før UpdatePizzaUI, 
            //fordi den instantierer extraslisten
            ResetUI();

            UpdatePizzaUI();

        }

        private void RejermedtunPizzaGroupBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pizzaType = "Rejermedtun";

            ResetUI();

            UpdatePizzaUI();

        }

        private void SkinkePizzaGroupBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pizzaType = "Skinke";

            ResetUI();

            UpdatePizzaUI();

        }

        private void KebabPizzaGroupBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pizzaType = "Kebab";

            ResetUI();

            UpdatePizzaUI();

        }

        //Tilbøhør tilføjes
        private void PepperoniExtraCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            extrasList.Add("Pepperoni");

            UpdatePizzaUI();
        }

        private void PepperoniExtraCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            extrasList.Remove("Pepperoni");

            UpdatePizzaUI();
        }

        private void CheeseExtraCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            extrasList.Add("Cheese");

            UpdatePizzaUI();
        }

        private void CheeseExtraCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            extrasList.Remove("Cheese");

            UpdatePizzaUI();
        }

        private void FamilyPizzaCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            extrasList.Add("Family");

            UpdatePizzaUI();

        }

        private void FamilyPizzaCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            extrasList.Remove("Family");

            UpdatePizzaUI();

        }

        private void AddPizzaButton_Click(object sender, RoutedEventArgs e)
        {
            //Hvis pizzalisten er null laves en ny instans
            if (PizzaList == null)
            {
                PizzaList = new List<IPizza>();
            }

            //Aktuelle pizza tilføjes til listen
            PizzaList.Add(pizza);

            //Aktuelle pizza sættes til null
            pizzaType = null;
            pizza = null;

            ResetUI();

            UpdatePizzaUI();

        }

        private void UpdatePizzaUI()
        {
            if (pizzaType != null)
            {
                //Laver Pizza med toppings
                pizza = MakePizza(extrasList);

                //Pris og Calorie label opdateres
                PriceLabel.Content = string.Format("{0:C}",pizza.Price());
                CaloriesLabel.Content = pizza.Calories() + " kcal";

                ExtrasGroupBox.Visibility = Visibility.Visible;
            }

            if (PizzaList != null)
            {
                //Udskrive en listeoversigt med pizzaer
                string pizza_label = "Kurv \n";
                double total_price = 0;
                double total_calories = 0;

                foreach (IPizza pizza in PizzaList)
                {
                    pizza_label += string.Format("{0} \n", pizza.Name());

                    total_price += pizza.Price();

                    total_calories += pizza.Calories();
                }

                PizzaListLabel.Content = pizza_label;

                //Total pris og kalorier opdateres
                PriceTotalLabel.Content = string.Format("{0:C}", total_price);
                CaloriesTotalLabel.Content = total_calories + " kcal";
            }
        }

        private void ResetUI()
        {
            extrasList = new List<string>();

            //UI nulstilles
            PriceLabel.Content = "0 kr.";
            CaloriesLabel.Content = "0 kcal";

            PepperoniExtraCheckbox.IsChecked = false;
            CheeseExtraCheckbox.IsChecked = false;
            FamilyPizzaCheckbox.IsChecked = false;

            ExtrasGroupBox.Visibility = Visibility.Hidden;
        }

        //Pizza laves i factory, og decorators tilføjes
        private IPizza MakePizza(List<string> _extrasList)
        {
            IPizza _pizza = pizza_factory.CreatePizza(pizzaType);

            foreach (string extra in _extrasList)
            {
                _pizza = pizza_factory.AddExtras(extra,_pizza);
            }

            return _pizza;
        }

    }
}
