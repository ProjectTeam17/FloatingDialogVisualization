using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using FloatingDialogVisualisation.Model;

namespace FloatingDialogVisualisation.viewmodel
{
    public class VwModal
    {
        /// <summary>
        /// Flag Variable for checking if menu is closed or open
        /// </summary>
        private static bool IsDialogDisplayed;

        /// <summary>
        /// DBContext for interacting with Database to fetch components values
        /// </summary>
        private static PowerPlantDataBaseEntities db;

        #region Vaccum Variable
        /// <summary>
        /// Vaccum Menu Open Variable Type ICommand
        /// </summary>
        private ICommand _vaccumPopOpen;
        /// <summary>
        /// Vaccum Menu Close Variable Type ICommand
        /// </summary>
        private ICommand _vaccumPopClose;                           

        private ICommand _vaccumNameClicked;                    //Vaccum Menu Name Pin Click Variable Type ICommand
        private ICommand _vaccumlabelName_clicked;              //Vaccum Menu Name UnPin Click Variable Type ICommand

        private ICommand _vaccumPowerClicked;                   //Vaccum Menu Power Pin Click Variable Type ICommand
        private ICommand _vaccumlabelpower_clicked;             //Vaccum Menu Power UnPin Click Variable Type ICommand

        private ICommand _vaccumPressureClicked;                //Vaccum Menu Pressure Pin Click Variable Type ICommand
        private ICommand _vaccumlabelPressure_clicked;          //Vaccum Menu Pressure UnPin Click Variable Type ICommand

        private ICommand _vaccumSpeedClicked;                   //Vaccum Menu Speed Pin Click Variable Type ICommand
        private ICommand _vaccumlabelSpeed_clicked;             //Vaccum Menu Speed UnPin Click Variable Type ICommand

        private ICommand _vaccumTemperatureClicked;             //Vaccum Menu Temperature Pin Click Variable Type ICommand    
        private ICommand _vaccumlabelTemperature_clicked;       //Vaccum Menu Temperature UnPin Click Variable Type ICommand

        private ICommand _vacuumChanged;
        

        #endregion

        #region Generator Variables

        private ICommand _generatorPopOpen;                     //Generator Menu Open Variable Type ICommand
        private ICommand _generatorPopClose;                    //Generator Menu Close Variable Type ICommand

        private ICommand _genratorNameClicked;                  //Generator Menu Name Pin Click Variable Type ICommand
        private ICommand _genratorLabelImgName_clicked;         //Generator Menu Name UnPin Click Variable Type ICommand

        private ICommand _genratorPowerClicked;                 //Generator Menu Power Pin Click Variable Type ICommand
        private ICommand _genratorLabelImgPower_clicked;        //Generator Menu Power UnPin Click Variable Type ICommand

        private ICommand _genratorPressureClicked;              //Generator Menu Pressure Pin Click Variable Type ICommand
        private ICommand _genratorLabelImgPressure_clicked;     //Generator Menu Pressure UnPin Click Variable Type ICommand

        private ICommand _genratorSpeedClicked;                 //Generator Menu Speed Pin Click Variable Type ICommand
        private ICommand _genratorLabelImgSpeed_clicked;        //Generator Menu Speed UnPin Click Variable Type ICommand

        private ICommand _genratorTemperatureClicked;           //Generator Menu Temperature Pin Click Variable Type ICommand
        private ICommand _genratorLabelImgTemperature_clicked;  //Generator Menu Temperature UnPin Click Variable Type ICommand

        private ICommand _generatorChanged;

        #endregion

        #region Turbine Variables

        private ICommand _turbinePopOpen;                       //Turbine Menu Open Variable Type ICommand
        private ICommand _turbinePopClose;                      //Turbine Menu Close Variable Type ICommand

        private ICommand _turbineNameClicked;                   //Turbine Menu Name Pin Click Variable Type ICommand
        private ICommand _turbinelabelImgName_clicked;          //Turbine Menu Name UnPin Click Variable Type ICommand

        private ICommand _turbinePowerClicked;                  //Turbine Menu Power Pin Click Variable Type ICommand
        private ICommand _turbinelabelImgPower_clicked;         //Turbine Menu Power UnPin Click Variable Type ICommand

        private ICommand _turbinePressureClicked;               //Turbine Menu Pressure Pin Click Variable Type ICommand
        private ICommand _turbinelabelImgPressure_clicked;      //Turbine Menu Pressure UnPin Click Variable Type ICommand

        private ICommand _turbineSpeedClicked;                  //Turbine Menu Speed Pin Click Variable Type ICommand
        private ICommand _turbinelabelImgSpeed_clicked;         //Turbine Menu Speed UnPin Click Variable Type ICommand

        private ICommand _turbineTemperatureClicked;            //Turbine Menu Temperature Pin Click Variable Type ICommand
        private ICommand _turbinelabelImgTemperature_clicked;   //Turbine Menu Temperature UnPin Click Variable Type ICommand

        private ICommand _turbineChanged;

        #endregion

        #region Condensor Variables

        private ICommand _condensorPopOpen;                     //Condensor Menu Open Variable Type ICommand
        private ICommand _condensorPopClose;                    //Condensor Menu Close Variable Type ICommand

        private ICommand _condensoritemNameClicked;             //Condensor Menu Name Pin Click Variable Type ICommand
        private ICommand _condensorlabelImgName_clicked;        //Condensor Menu Name UnPin Click Variable Type ICommand

        private ICommand _condensorPowerClicked;                //Condensor Menu Power Pin Click Variable Type ICommand
        private ICommand _condensorlabelImgPower_clicked;       //Condensor Menu Power UnPin Click Variable Type ICommand

        private ICommand _condensorPressureClicked;             //Condensor Menu Pressure Pin Click Variable Type ICommand
        private ICommand _condensorlabelImgPressure_clicked;    //Condensor Menu Pressure UnPin Click Variable Type ICommand

        private ICommand _condensorSpeedClicked;                //Condensor Menu Speed Pin Click Variable Type ICommand
        private ICommand _condensorlabelImgSpeed_clicked;       //Condensor Menu Speed UnPin Click Variable Type ICommand

        private ICommand _condensorTemperatureClicked;          //Condensor Menu Temperature Pin Click Variable Type ICommand
        private ICommand _condensorlabelImgTemperature_clicked; //Condensor Menu Temperature UnPin Click Variable Type ICommand

        private ICommand _condensorChanged;

        #endregion

        /// <summary>
        /// Initializing the DB Context object
        /// </summary>
        public VwModal() {
            db = new PowerPlantDataBaseEntities();
        }  //View Modal Class Constructor

        #region Vaccum Pump

            #region Event Handling

            public ICommand VaccumPopOpen                                               //Vaccum Menu Open Property Calling VaccumMenuOpen() Method using Relay Command
            {
                get => _vaccumPopOpen ?? (_vaccumPopOpen = new RelayCommand(x => DisplayVacuumComponentMenu()));

                set => _vaccumPopOpen = value;
            }                                                                                               
            public ICommand VaccumPopClose                                              //Vaccum Menu Close Property Calling VaccumMenuClose() Method using Relay Command
            {
                get => _vaccumPopClose ?? (_vaccumPopClose = new RelayCommand(x => VaccumMenuClose()));

                set => _vaccumPopClose = value;
            }                                                                                          

            public ICommand VaccumNameClicked                                           //Vaccum Name Pin Click Property Calling VaccumMenu_Name_Pin() Method using Relay Command
            {
                get => _vaccumNameClicked ?? (_vaccumNameClicked = new RelayCommand(x => VaccumMenu_Name_Pin()));

                set => _vaccumNameClicked = value;
            }                                                                                  

            public ICommand VaccumMenuLabelImgName_clicked                              //Vaccum Name UnPin Click Property Calling VaccumMenu_Name_UnPin() Method using Relay Command
            {
                get => _vaccumlabelName_clicked ?? (_vaccumlabelName_clicked = new RelayCommand(x => VaccumMenu_Name_UnPin()));

                set => _vaccumlabelName_clicked = value;
            }                                                 


            public ICommand VaccumPowerClicked                                          //Vaccum Power Pin Click Property Calling VaccumMenu_Power_Pin() Method using Relay Command
            {
                get => _vaccumPowerClicked ?? (_vaccumPowerClicked = new RelayCommand(x => VaccumMenu_Power_Pin()));

                set => _vaccumPowerClicked = value;
            }                                                                             

            public ICommand VaccumMenuLabelImgPower_clicked                             //Vaccum Power UnPin Click Property Calling VaccumMenu_Power_UnPin() Method using Relay Command   
            {
                get => _vaccumlabelpower_clicked ?? (_vaccumlabelpower_clicked = new RelayCommand(x => VaccumMenu_Power_UnPin()));

                set => _vaccumlabelpower_clicked = value;
            }                                            


            public ICommand VaccumPressureClicked                                       //Vaccum Pressure Pin Click Property Calling VaccumMenu_Presure_Pin() Method using Relay Command
            {
                get => _vaccumPressureClicked ?? (_vaccumPressureClicked = new RelayCommand(x => VaccumMenu_Pressure_Pin()));

                set => _vaccumPressureClicked = value;
            }

            public ICommand VaccumMenuLabelImgPressure_clicked                          //Vaccum Pressure UnPin Click Property Calling VaccumMenu_Presure_UnPin() Method using Relay Command
            {
                get => _vaccumlabelPressure_clicked ?? (_vaccumlabelPressure_clicked = new RelayCommand(x => VaccumMenu_Pressure_UnPin()));

                set => _vaccumlabelPressure_clicked = value;
            }


            public ICommand VaccumSpeedClicked                                          //Vaccum Speed Pin Click Property Calling VaccumMenu_Speed_Pin() Method using Relay Command
            {
                get => _vaccumSpeedClicked ?? (_vaccumSpeedClicked = new RelayCommand(x => VaccumMenu_Speed_Pin()));

                set => _vaccumSpeedClicked = value;
            }

            public ICommand VaccumMenuLabelImgSpeed_clicked                             //Vaccum Speed UnPin Click Property Calling VaccumMenu_Speed_UnPin() Method using Relay Command
            {
                get => _vaccumlabelSpeed_clicked ?? (_vaccumlabelSpeed_clicked = new RelayCommand(x => VaccumMenu_Speed_UnPin()));

                set => _vaccumlabelSpeed_clicked = value;
            }


            public ICommand VaccumTemperatureClicked                                    //Vaccum Temperature Pin Click Property Calling VaccumMenu_Temperature_Pin() Method using Relay Command
            {
                get => _vaccumTemperatureClicked ?? (_vaccumTemperatureClicked = new RelayCommand(x => VaccumMenu_Temperature_Pin()));

                set => _vaccumTemperatureClicked = value;
            }

            public ICommand VaccumMenuLabelImgTemperature_clicked                       //Vaccum Temperature UnPin Click Property Calling VaccumMenu_Temperature_UnPin() Method using Relay Command
            {
                get => _vaccumlabelTemperature_clicked ?? (_vaccumlabelTemperature_clicked = new RelayCommand(x => VaccumMenu_Temperature_UnPin()));

                set => _vaccumlabelTemperature_clicked = value;
            }

            public ICommand VaccumChanged                                               //Vaccum Menu Open Property Calling VaccumMenuOpen() Method using Relay Command
            {
                get => _vacuumChanged ?? (_vacuumChanged = new RelayCommand(x => VaccumChangedMethod()));

                set => _vacuumChanged = value;
            }

        #endregion

        /// <summary>
        /// Handles mouse hover event on Vaccum Component when user hovers. Attempts displaying vacuum components menu 
        /// </summary>
        private static void DisplayVacuumComponentMenu()                                                // Vaccum Menu Open Method 
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            //if(mainWindow.generatorMenu.IsOpen == false && mainWindow.turbineMenu.IsOpen == false && mainWindow.condensorMenu.IsOpen == false)
            {
                try
                {
                    var powerPlantComponents = from component in db.PowerPlantComponents
                              where component.ComponentID == 1
                              select component;
                    foreach (var item in powerPlantComponents)
                    {
                        mainWindow.vaccumMenuNameHeader.Header      = "Name : " + item.ComponentName;
                        mainWindow.vaccumMenuPower.Header           = "Power : " + item.Power;
                        mainWindow.vaccumMenuPowerTxt.Text          = item.Power.ToString();
                        mainWindow.vaccumMenuPressure.Header        = "Pressure : " + item.Pressure;
                        mainWindow.vaccumMenuPressureTxt.Text       = item.Pressure.ToString();
                        mainWindow.vaccumMenuSpeed.Header           = "Speed : " + item.Speed;
                        mainWindow.vaccumMenuSpeedTxt.Text          = item.Speed.ToString();
                        mainWindow.vaccumMenuTemperature.Header     = "Temperature : " + item.Temperature;
                        mainWindow.vaccumMenuTemperatureTxt.Text    = item.Temperature.ToString();
                    }

                    mainWindow.vaccumMenu.IsOpen = true;
                    IsDialogDisplayed = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Loading Vaccum COmponent Data From Database");
                }
            }

        }

        private static void VaccumMenuClose()                                               // Vaccum Menu Close Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.vaccumMenu.IsOpen = false;
            IsDialogDisplayed = false;
        }


        private static void VaccumMenu_Name_Pin()                                           //Vaccum Menu Name Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.vaccumNamePin.Visibility = Visibility.Hidden;
            mainWindow.vaccumMenuName_prop_img.Visibility = Visibility.Visible;
            mainWindow.vaccumMenuName_prop.Content = mainWindow.vaccumMenuNameHeader.Header;
        }

        private static void VaccumMenu_Name_UnPin()                                          //Vaccum Menu Name Unpining Method
        {   
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.vaccumNamePin.Visibility = Visibility.Visible;
                mainWindow.vaccumMenuName_prop_img.Visibility = Visibility.Hidden;
                mainWindow.vaccumMenuName_prop.Content = "";
            }
        }


        private static void VaccumMenu_Power_Pin()                                           //Vaccum Menu Power Pining Method
        {   
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.vaccumPowerPin.Visibility = Visibility.Hidden;
            mainWindow.vaccumMenuPower_prop_img.Visibility = Visibility.Visible;
            mainWindow.vaccumMenuPower_prop.Content = mainWindow.vaccumMenuPower.Header;
        }

        private static void VaccumMenu_Power_UnPin()                                         //Vaccum Menu Power Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.vaccumMenuPower_prop_img.Visibility = Visibility.Hidden;
                mainWindow.vaccumPowerPin.Visibility = Visibility.Visible;
                mainWindow.vaccumMenuPower_prop.Content = "";
            }
        }


        private static void VaccumMenu_Pressure_Pin()                                        //Vaccum Menu Pressure Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.vaccumPressurePin.Visibility = Visibility.Hidden;
            mainWindow.vaccumMenuPressure_prop_img.Visibility = Visibility.Visible;
            mainWindow.vaccumMenuPressure_prop.Content = mainWindow.vaccumMenuPressure.Header;
        }

        private static void VaccumMenu_Pressure_UnPin()                                      //Vaccum Menu Pressure Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.vaccumMenuPressure_prop_img.Visibility = Visibility.Hidden;
                mainWindow.vaccumPressurePin.Visibility = Visibility.Visible;
                mainWindow.vaccumMenuPressure_prop.Content = "";
            }
        }


        private static void VaccumMenu_Speed_Pin()                                           //Vaccum Menu Speed Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.vaccumSpeedPin.Visibility = Visibility.Hidden;
            mainWindow.vaccumMenuSpeed_prop_img.Visibility = Visibility.Visible;
            mainWindow.vaccumMenuSpeed_prop.Content = mainWindow.vaccumMenuSpeed.Header;
        }

        private static void VaccumMenu_Speed_UnPin()                                         //Vaccum Menu Speed Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.vaccumMenuSpeed_prop_img.Visibility = Visibility.Hidden;
                mainWindow.vaccumSpeedPin.Visibility = Visibility.Visible;
                mainWindow.vaccumMenuSpeed_prop.Content = "";
            }
        }


        private static void VaccumMenu_Temperature_Pin()                                     //Vaccum Menu Temperature Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.vaccumTemperaturePin.Visibility = Visibility.Hidden;
            mainWindow.vaccumMenuTemperature_prop_img.Visibility = Visibility.Visible;
            mainWindow.vaccumMenuTemperature_prop.Content = mainWindow.vaccumMenuTemperature.Header;
        }

        private static void VaccumMenu_Temperature_UnPin()                                   //Vaccum Menu Temprerature Unping Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.vaccumMenuTemperature_prop_img.Visibility = Visibility.Hidden;
                mainWindow.vaccumTemperaturePin.Visibility = Visibility.Visible;
                mainWindow.vaccumMenuTemperature_prop.Content = "";
            }
        }

        private static void VaccumChangedMethod()
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            try
            {
                PowerPlantComponent component = db.PowerPlantComponents.Find(1);
                component.Power = mainWindow.vaccumMenuPowerTxt.Text.ToString();
                component.Pressure = mainWindow.vaccumMenuPressureTxt.Text.ToString();
                component.Speed = mainWindow.vaccumMenuSpeedTxt.Text.ToString();
                component.Temperature = mainWindow.vaccumMenuTemperatureTxt.Text.ToString();
                db.SaveChanges();
                DisplayVacuumComponentMenu();
                if(mainWindow.vaccumMenuPower_prop_img.IsVisible)
                {
                    VaccumMenu_Power_Pin();
                }
                if(mainWindow.vaccumMenuPressure_prop_img.IsVisible)
                {
                    VaccumMenu_Pressure_Pin();
                }
                if(mainWindow.vaccumMenuSpeed_prop_img.IsVisible)
                {
                    VaccumMenu_Speed_Pin();
                }
                if(mainWindow.vaccumMenuTemperature_prop_img.IsVisible)
                {
                    VaccumMenu_Temperature_Pin();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        #endregion

        #region Generator

        #region EventHandling

        public ICommand GeneratorPopOpen                                                 //Generator Menu Open Property Calling GeneratorMenuOpen() Method using Relay Command
            {
                get => _generatorPopOpen ?? (_generatorPopOpen = new RelayCommand(x => DisplayGeneratorComponentMenu()));

                set => _generatorPopOpen = value;
            }

            public ICommand GeneratorPopClose                                               //Generator Menu Close Property Calling GeneratorMenuClose() Method using Relay Command
            {
                get => _generatorPopClose ?? (_generatorPopClose = new RelayCommand(x => GeneratorMenuClose()));

                set => _generatorPopClose = value;
            }


            public ICommand GeneratorNameClicked                                            //Generator Name Pin Click Property Calling GeneratorMenu_Name_Pin() Method using Relay Command
            {
                get => _genratorNameClicked ?? (_genratorNameClicked = new RelayCommand(x => GeneratorMenu_Name_Pin()));

                set => _genratorNameClicked = value;
            }

            public ICommand GeneratorLabelImgName_clicked                                   //Generator Name UnPin Click Property Calling GeneratorMenu_Name_UnPin() Method using Relay Command
            {
                get => _genratorLabelImgName_clicked ?? (_genratorLabelImgName_clicked = new RelayCommand(x => GeneratorMenu_Name_UnPin()));

                set => _genratorLabelImgName_clicked = value;
            }


            public ICommand GeneratorPowerClicked                                           //Generator Power Pin Click Property Calling GeneratorMenu_Power_Pin() Method using Relay Command
            {
                get => _genratorPowerClicked ?? (_genratorPowerClicked = new RelayCommand(x => GeneratorMenu_Power_Pin()));

                set => _genratorPowerClicked = value;
            }

            public ICommand GeneratorLabelImgPower_clicked                                  //Generator Power UnPin Click Property Calling GeneratorMenu_Power_UnPin() Method using Relay Command
            {
                get => _genratorLabelImgPower_clicked ?? (_genratorLabelImgPower_clicked = new RelayCommand(x => GeneratorMenu_Power_UnPin()));

                set => _genratorLabelImgPower_clicked = value;
            }


            public ICommand GeneratorPressureClicked                                        //Generator Pressure Pin Click Property Calling GeneratorMenu_Pressure_Pin() Method using Relay Command
            {
                get => _genratorPressureClicked ?? (_genratorPressureClicked = new RelayCommand(x => GeneratorMenu_Pressure_Pin()));

                set => _genratorPressureClicked = value;
            }

            public ICommand GeneratorLabelImgPressure_clicked                               //Generator Pressure UnPin Click Property Calling GeneratorMenu_Pressure_UnPin() Method using Relay Command
            {
                get => _genratorLabelImgPressure_clicked ?? (_genratorLabelImgPressure_clicked = new RelayCommand(x => GeneratorMenu_Pressure_UnPin()));

                set => _genratorLabelImgPressure_clicked = value;
            }


            public ICommand GeneratorSpeedClicked                                           //Generator Speed Pin Click Property Calling GeneratorMenu_Speed_Pin() Method using Relay Command
            {
                get => _genratorSpeedClicked ?? (_genratorSpeedClicked = new RelayCommand(x => GeneratorMenu_Speed_Pin()));

                set => _genratorSpeedClicked = value;
            }

            public ICommand GeneratorLabelImgSpeed_clicked                                  //Generator Speed UnPin Click Property Calling GeneratorMenu_Speed_UnPin() Method using Relay Command
            {
                get => _genratorLabelImgSpeed_clicked ?? (_genratorLabelImgSpeed_clicked = new RelayCommand(x => GeneratorMenu_Speed_UnPin()));

                set => _genratorLabelImgSpeed_clicked = value;
            }


            public ICommand GeneratorTemperatureClicked                                     //Generator Temperature Pin Click Property Calling GeneratorMenu_Temperature_Pin() Method using Relay Command
            {
                get => _genratorTemperatureClicked ?? (_genratorTemperatureClicked = new RelayCommand(x => GeneratorMenu_Temperature_Pin()));

                set => _genratorTemperatureClicked = value;
            }

            public ICommand GeneratorLabelImgtemperature_clicked                            //Generator Temperature UnPin Click Property Calling GeneratorMenu_Temperature_UnPin() Method using Relay Command
            {
                get => _genratorLabelImgTemperature_clicked ?? (_genratorLabelImgTemperature_clicked = new RelayCommand(x => GeneratorMenu_Temperature_UnPin()));

                set => _genratorLabelImgTemperature_clicked = value;
            }

            public ICommand GeneratorChanged                           //Generator Temperature UnPin Click Property Calling GeneratorMenu_Temperature_UnPin() Method using Relay Command
            {
                get => _generatorChanged ?? (_generatorChanged = new RelayCommand(x => GeneratorChangedMethod()));

                set => _generatorChanged = value;
            }

        #endregion

        /// <summary>
        /// Handles mouse hover event on Generator Component when user hovers. Attempts displaying genertor components menu 
        /// </summary>
        private static void DisplayGeneratorComponentMenu()                                             //Generator Menu Open Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            try
            {
                //if (mainWindow.vaccumMenu.IsOpen == false && mainWindow.turbineMenu.IsOpen == false && mainWindow.condensorMenu.IsOpen == false)
                {
                    var powerPlantComponents = from component in db.PowerPlantComponents
                              where component.ComponentID == 3
                              select component;
                    foreach (var item in powerPlantComponents)
                    {
                        mainWindow.generatorName.Header                 = "Name : " + item.ComponentName;
                        mainWindow.generatorPower.Header                = "Power : " + item.Power;
                        mainWindow.generatorMenuPowerTxt.Text           = item.Power;
                        mainWindow.generatorPressure.Header             = "Pressure : " + item.Pressure;
                        mainWindow.generatorMenuPressureTxt.Text        = item.Pressure;
                        mainWindow.generatorSpeed.Header                = "Speed : " + item.Speed;
                        mainWindow.generatorMenuSpeedTxt.Text           = item.Speed;
                        mainWindow.generatorTemperature.Header          = "Temperature : " + item.Temperature;
                        mainWindow.generatorMenuTemperatureTxt.Text     = item.Temperature;
                    }

                    mainWindow.generatorMenu.IsOpen = true;
                    IsDialogDisplayed = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Loading Generator component Data from Database");
            }
        }

        private static void GeneratorMenuClose()                                            //Generator Menu Close Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.generatorMenu.IsOpen = false;
            IsDialogDisplayed = false;
        }


        private static void GeneratorMenu_Name_Pin()                                         //Generator Menu Name Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.generatorNamePin.Visibility = Visibility.Hidden;
            mainWindow.generatorName_prop_img.Visibility = Visibility.Visible;
            mainWindow.generatorName_prop.Content = mainWindow.generatorName.Header;
        }

        private static void GeneratorMenu_Name_UnPin()                                       //Generator Menu Name Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.generatorName_prop_img.Visibility = Visibility.Hidden;
                mainWindow.generatorNamePin.Visibility = Visibility.Visible;
                mainWindow.generatorName_prop.Content = "";
            }
        }

        private static void GeneratorMenu_Power_Pin()                                        //Generator Menu Power Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.generatorPowerPin.Visibility = Visibility.Hidden;
            mainWindow.generatorPower_prop_img.Visibility = Visibility.Visible;
            mainWindow.generatorPower_prop.Content = mainWindow.generatorPower.Header;
        }

        private static void GeneratorMenu_Power_UnPin()                                      //Generator Menu Power Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.generatorPower_prop_img.Visibility = Visibility.Hidden;
                mainWindow.generatorPowerPin.Visibility = Visibility.Visible;
                mainWindow.generatorPower_prop.Content = "";
            }
        }

        private static void GeneratorMenu_Pressure_Pin()                                     //Generator Menu Pressure Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.generatorPressurePin.Visibility = Visibility.Hidden;
            mainWindow.generatorPressure_prop_img.Visibility = Visibility.Visible;
            mainWindow.generatorPressure_prop.Content = mainWindow.generatorPressure.Header;
        }

        private static void GeneratorMenu_Pressure_UnPin()                                   //Generator Menu Pressure Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.generatorPressure_prop_img.Visibility = Visibility.Hidden;
                mainWindow.generatorPressurePin.Visibility = Visibility.Visible;
                mainWindow.generatorPressure_prop.Content = "";
            }
        }

        private static void GeneratorMenu_Speed_Pin()                                        //Generator Menu Speed Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.generatorSpeedPin.Visibility = Visibility.Hidden;
            mainWindow.generatorSpeed_prop_img.Visibility = Visibility.Visible;
            mainWindow.generatorSpeed_prop.Content = mainWindow.generatorSpeed.Header;
        }

        private static void GeneratorMenu_Speed_UnPin()                                      //Generator Menu Speed Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.generatorSpeed_prop_img.Visibility = Visibility.Hidden;
                mainWindow.generatorSpeedPin.Visibility = Visibility.Visible;
                mainWindow.generatorSpeed_prop.Content = "";
            }
        }

        private static void GeneratorMenu_Temperature_Pin()                                  //Generator Menu Temperature Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.generatorTemperaturPin.Visibility = Visibility.Hidden;
            mainWindow.generatorTemperature_prop_img.Visibility = Visibility.Visible;
            mainWindow.generatorTemperature_prop.Content = mainWindow.generatorTemperature.Header;
        }

        private static void GeneratorMenu_Temperature_UnPin()                                //Generator Menu Temperature Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.generatorTemperature_prop_img.Visibility = Visibility.Hidden;
                mainWindow.generatorTemperaturPin.Visibility = Visibility.Visible;
                mainWindow.generatorTemperature_prop.Content = "";
            }
        }

        private static void GeneratorChangedMethod()
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            try
            {
                PowerPlantComponent component = db.PowerPlantComponents.Find(3);
                component.Power = mainWindow.generatorMenuPowerTxt.Text.ToString();
                component.Pressure = mainWindow.generatorMenuPressureTxt.Text.ToString();
                component.Speed = mainWindow.generatorMenuSpeedTxt.Text.ToString();
                component.Temperature = mainWindow.generatorMenuTemperatureTxt.Text.ToString();
                db.SaveChanges();
                DisplayGeneratorComponentMenu();
                if (mainWindow.generatorPower_prop_img.IsVisible)
                {
                    GeneratorMenu_Power_Pin();
                }
                if (mainWindow.generatorPressure_prop_img.IsVisible)
                {
                    GeneratorMenu_Pressure_Pin();
                }
                if (mainWindow.generatorSpeed_prop_img.IsVisible)
                {
                    GeneratorMenu_Speed_Pin();
                }
                if (mainWindow.generatorTemperature_prop_img.IsVisible)
                {
                    GeneratorMenu_Temperature_Pin();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        #endregion

        #region Turbine

            #region EventHandling

            public ICommand TurbinePopOpen                                                  //Turbine Menu Open Property Calling TurbineMenuOpen() Method using Relay Command
            {
                get => _turbinePopOpen ?? (_turbinePopOpen = new RelayCommand(x => DisplayTurbineComponentMenu()));

                set => _turbinePopOpen = value;
            }

            public ICommand TurbinePopClose                                                 //Turbine Menu Close Property Calling TurbineMenuClose() Method using Relay Command
            {
                get => _turbinePopClose ?? (_turbinePopClose = new RelayCommand(x => TurbineMenuClose()));

                set => _turbinePopClose = value;
            }


            public ICommand TurbineMenuNameClicked                                          //Turbine Name Pin Click Property Calling TurbineMenu_Name_Pin() Method using Relay Command
            {
                get => _turbineNameClicked ?? (_turbineNameClicked = new RelayCommand(x => TurbineMenu_Name_Pin()));

                set => _turbineNameClicked = value;
            }

            public ICommand TurbineMenuLabelImgName_clicked                                 //Turbine Name UnPin Click Property Calling TurbineMenu_Name_UnPin() Method using Relay Command
            {
                get => _turbinelabelImgName_clicked ?? (_turbinelabelImgName_clicked = new RelayCommand(x => TurbineMenu_Name_UnPin()));

                set => _turbinelabelImgName_clicked = value;
            }


            public ICommand TurbineMenuPowerClicked                                         //Turbine Power Pin Click Property Calling TurbineMenu_Power_Pin() Method using Relay Command
            {
                get => _turbinePowerClicked ?? (_turbinePowerClicked = new RelayCommand(x => TurbineMenu_Power_Pin()));

                set => _turbinePowerClicked = value;
            }

            public ICommand TurbineMenuLabelImgPower_clicked                                //Turbine Power UnPin Click Property Calling TurbineMenu_Power_UnPin() Method using Relay Command
            {
                get => _turbinelabelImgPower_clicked ?? (_turbinelabelImgPower_clicked = new RelayCommand(x => TurbineMenu_Power_UnPin()));

                set => _turbinelabelImgPower_clicked = value;
            }


            public ICommand TurbineMenuPressureClicked                                      //Turbine Pressure Pin Click Property Calling TurbineMenu_Pressure_Pin() Method using Relay Command
            {
                get => _turbinePressureClicked ?? (_turbinePressureClicked = new RelayCommand(x => TurbineMenu_Pressure_Pin()));

                set => _turbinePressureClicked = value;
            }

            public ICommand TurbineMenuLabelImgPressure_clicked                             //Turbine Pressure UnPin Click Property Calling TurbineMenu_Pressure_UnPin() Method using Relay Command
            {
                get => _turbinelabelImgPressure_clicked ?? (_turbinelabelImgPressure_clicked = new RelayCommand(x => TurbineMenu_Pressure_UnPin()));

                set => _turbinelabelImgPressure_clicked = value;
            }


            public ICommand TurbineMenuSpeedClicked                                         //Turbine Speed Pin Click Property Calling TurbineMenu_Speed_Pin() Method using Relay Command
            {
                get => _turbineSpeedClicked ?? (_turbineSpeedClicked = new RelayCommand(x => TurbineMenu_Speed_Pin()));

                set => _turbineSpeedClicked = value;
            }

            public ICommand TurbineMenuLabelImgSpeed_clicked                                //Turbine Speed UnPin Click Property Calling TurbineMenu_Speed_UnPin() Method using Relay Command
            {
                get => _turbinelabelImgSpeed_clicked ?? (_turbinelabelImgSpeed_clicked = new RelayCommand(x => TurbineMenu_Speed_UnPin()));

                set => _turbinelabelImgSpeed_clicked = value;
            }


            public ICommand TurbineMenuTemperatureClicked                                   //Turbine Temperature Pin Click Property Calling TurbineMenu_Temperature_Pin() Method using Relay Command
            {
                get => _turbineTemperatureClicked ?? (_turbineTemperatureClicked = new RelayCommand(x => TurbineMenu_Temperature_Pin()));

                set => _turbineTemperatureClicked = value;
            }

            public ICommand TurbineMenuLabelImgTemperature_clicked                          //Turbine Temperature UnPin Click Property Calling TurbineMenu_Temperature_UnPin() Method using Relay Command
            {
                get => _turbinelabelImgTemperature_clicked ?? (_turbinelabelImgTemperature_clicked = new RelayCommand(x => TurbineMenu_Temperature_UnPin()));

                set => _turbinelabelImgTemperature_clicked = value;
            }

            public ICommand TurbineChanged                          //Turbine Temperature UnPin Click Property Calling TurbineMenu_Temperature_UnPin() Method using Relay Command
            {
                get => _turbineChanged ?? (_turbineChanged = new RelayCommand(x => TurbineChangedMethod()));

                set => _turbineChanged = value;
            }

        #endregion

        /// <summary>
        /// Handles mouse hover event on Turbine Component when user hovers. Attempts displaying Turbine components menu 
        /// </summary>
        private static void DisplayTurbineComponentMenu()                                               //Turbine Menu Open Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            try
            {
                //if (mainWindow.vaccumMenu.IsOpen == false && mainWindow.generatorMenu.IsOpen == false && mainWindow.condensorMenu.IsOpen == false)
                {
                    var powerPlantComponents = from component in db.PowerPlantComponents
                              where component.ComponentID == 4
                              select component;
                    foreach (var item in powerPlantComponents)
                    {
                        mainWindow.turbineMenuName.Header           = "Name : " + item.ComponentName;
                        mainWindow.turbineMenuPower.Header          = "Power : " + item.Power;
                        mainWindow.turbineMenuPowerTxt.Text         = item.Power;
                        mainWindow.turbineMenuPressure.Header       = "Pressure : " + item.Pressure;
                        mainWindow.turbineMenuPressureTxt.Text      = item.Pressure;
                        mainWindow.turbineMenuSpeed.Header          = "Speed : " + item.Speed;
                        mainWindow.turbineMenuSpeedTxt.Text         = item.Speed;
                        mainWindow.turbineMenuTemperature.Header    = "Temperature : " + item.Temperature;
                        mainWindow.turbineMenuTemperatureTxt.Text   = item.Temperature;
                    }


                    mainWindow.turbineMenu.IsOpen = true;
                    IsDialogDisplayed = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading Turbine component Data from Database");
            }
        }

        private static void TurbineMenuClose()                                              //Turbine Menu Close Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.turbineMenu.IsOpen = false;
            IsDialogDisplayed = false;
        }

        private static void TurbineMenu_Name_Pin()                                           //Turbine Menu Name Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.turbineNamePin.Visibility = Visibility.Hidden;
            mainWindow.turbineMenuName_prop_img.Visibility = Visibility.Visible;
            mainWindow.turbineMenuName_prop.Content = mainWindow.turbineMenuName.Header;
        }

        private static void TurbineMenu_Name_UnPin()                                         //Turbine Menu Name Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.turbineMenuName_prop_img.Visibility = Visibility.Hidden;
                mainWindow.turbineNamePin.Visibility = Visibility.Visible;
                mainWindow.turbineMenuName_prop.Content = "";
            }
        }

        private static void TurbineMenu_Power_Pin()                                          //Turbine Menu Power Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.turbinePowerPin.Visibility = Visibility.Hidden;
            mainWindow.turbineMenuPower_prop_img.Visibility = Visibility.Visible;
            mainWindow.turbineMenuPower_prop.Content = mainWindow.turbineMenuPower.Header;
        }

        private static void TurbineMenu_Power_UnPin()                                        //Turbine Menu Power Unining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.turbineMenuPower_prop_img.Visibility = Visibility.Hidden;
                mainWindow.turbinePowerPin.Visibility = Visibility.Visible;
                mainWindow.turbineMenuPower_prop.Content = "";
            }
        }

        private static void TurbineMenu_Pressure_Pin()                                       //Turbine Menu Pressure Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.turbinePressurePin.Visibility = Visibility.Hidden;
            mainWindow.turbineMenuPressure_prop_img.Visibility = Visibility.Visible;
            mainWindow.turbineMenuPressure_prop.Content = mainWindow.turbineMenuPressure.Header;
        }

        private static void TurbineMenu_Pressure_UnPin()                                     //Turbine Menu Pressure Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.turbineMenuPressure_prop_img.Visibility = Visibility.Hidden;
                mainWindow.turbinePressurePin.Visibility = Visibility.Visible;
                mainWindow.turbineMenuPressure_prop.Content = "";
            }
        }

        private static void TurbineMenu_Speed_Pin()                                          //Turbine Menu Speed Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.turbineSpeedPin.Visibility = Visibility.Hidden;
            mainWindow.turbineMenuSpeed_prop_img.Visibility = Visibility.Visible;
            mainWindow.turbineMenuSpeed_prop.Content = mainWindow.turbineMenuSpeed.Header;
        }

        private static void TurbineMenu_Speed_UnPin()                                        //Turbine Menu Speed Unpining Method
        {   
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.turbineMenuSpeed_prop_img.Visibility = Visibility.Hidden;
                mainWindow.turbineSpeedPin.Visibility = Visibility.Visible;
                mainWindow.turbineMenuSpeed_prop.Content = "";
            }
        }

        private static void TurbineMenu_Temperature_Pin()                                    //Turbine Menu Temperature Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.turbineTemperaturePin.Visibility = Visibility.Hidden;
            mainWindow.turbineMenuTemperature_prop_img.Visibility = Visibility.Visible;
            mainWindow.turbineMenuTemperature_prop.Content = mainWindow.turbineMenuTemperature.Header;
        }

        private static void TurbineMenu_Temperature_UnPin()                                  //Turbine Menu Temperature Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.turbineMenuTemperature_prop_img.Visibility = Visibility.Hidden;
                mainWindow.turbineTemperaturePin.Visibility = Visibility.Visible;
                mainWindow.turbineMenuTemperature_prop.Content = "";
            }
        }

        private static void TurbineChangedMethod()
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            try
            {
                PowerPlantComponent component = db.PowerPlantComponents.Find(4);
                component.Power = mainWindow.turbineMenuPowerTxt.Text.ToString();
                component.Pressure = mainWindow.turbineMenuPressureTxt.Text.ToString();
                component.Speed = mainWindow.turbineMenuSpeedTxt.Text.ToString();
                component.Temperature = mainWindow.turbineMenuTemperatureTxt.Text.ToString();
                db.SaveChanges();
                DisplayTurbineComponentMenu();
                if (mainWindow.turbineMenuPower_prop_img.IsVisible)
                {
                    TurbineMenu_Power_Pin();
                }
                if (mainWindow.turbineMenuPressure_prop_img.IsVisible)
                {
                    TurbineMenu_Pressure_Pin();
                }
                if (mainWindow.turbineMenuSpeed_prop_img.IsVisible)
                {
                    TurbineMenu_Speed_Pin();
                }
                if (mainWindow.turbineMenuTemperature_prop_img.IsVisible)
                {
                    TurbineMenu_Temperature_Pin();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        #endregion

        #region Condensor

            #region Event Handling

            public ICommand CondensorPopOpen                                                //Condensor Menu Open Property Calling CondensorMenuOpen() Method using Relay Command
            {
                get => _condensorPopOpen ?? (_condensorPopOpen = new RelayCommand(x => DisplayCondensorComponentMenu()));

                set => _condensorPopOpen = value;
            }

            public ICommand CondensorPopClose                                               //Condensor Menu Close Property Calling CondensorMenuClose() Method using Relay Command
            {
                get => _condensorPopClose ?? (_condensorPopClose = new RelayCommand(x => CondensorMenuClose()));

                set => _condensorPopClose = value;
            }

            public ICommand CondensorMenuNameClicked                                        //Condensor Name Pin Click Property Calling CondensorMenu_Name_Pin() Method using Relay Command
            {
                get => _condensoritemNameClicked ?? (_condensoritemNameClicked = new RelayCommand(x => CondensorMenu_Name_Pin()));

                set => _condensoritemNameClicked = value;
            }

            public ICommand CondensorMenuLabelImgName_clicked                               //Condensor Name UnPin Click Property Calling CondensorMenu_Name_UnPin() Method using Relay Command
            {
                get => _condensorlabelImgName_clicked ?? (_condensorlabelImgName_clicked = new RelayCommand(x => CondensorMenu_Name_UnPin()));

                set => _condensorlabelImgName_clicked = value;
            }


            public ICommand CondensorMenuPowerClicked                                       //Condensor Power Pin Click Property Calling CondensorMenu_Power_Pin() Method using Relay Command
            {
                get => _condensorPowerClicked ?? (_condensorPowerClicked = new RelayCommand(x => CondensorMenu_Power_Pin()));

                set => _condensorPowerClicked = value;
            }
            
            public ICommand CondensorMenuLabelImgPower_clicked                              //Condensor Power UnPin Click Property Calling CondensorMenu_Power_UnPin() Method using Relay Command
            {   
                get => _condensorlabelImgPower_clicked ?? (_condensorlabelImgPower_clicked = new RelayCommand(x => CondensorMenu_Power_UnPin()));

                set => _condensorlabelImgPower_clicked = value;
            }


            public ICommand CondensorMenuPressureClicked                                    //Condensor Pressure Pin Click Property Calling CondensorMenu_Pressure_Pin() Method using Relay Command
            {
                get => _condensorPressureClicked ?? (_condensorPressureClicked = new RelayCommand(x => CondensorMenu_Pressure_Pin()));

                set => _condensorPressureClicked = value;
            }

            public ICommand CondensorMenuLabelImgPressure_clicked                           //Condensor Pressure UnPin Click Property Calling CondensorMenu_Pressure_UnPin() Method using Relay Command
            {
                get => _condensorlabelImgPressure_clicked ?? (_condensorlabelImgPressure_clicked = new RelayCommand(x => CondensorMenu_Pressure_UnPin()));

                set => _condensorlabelImgPressure_clicked = value;
            }


            public ICommand CondensorMenuSpeedClicked                                       //Condensor Speed Pin Click Property Calling CondensorMenu_Speed_Pin() Method using Relay Command
            {
                get => _condensorSpeedClicked ?? (_condensorSpeedClicked = new RelayCommand(x => CondensorMenu_Speed_Pin()));

                set => _condensorSpeedClicked = value;
            }

            public ICommand CondensorMenuLabelImgSpeed_clicked                              //Condensor Speed UnPin Click Property Calling CondensorMenu_Speed_UnPin() Method using Relay Command
            {
                get => _condensorlabelImgSpeed_clicked ?? (_condensorlabelImgSpeed_clicked = new RelayCommand(x => CondensorMenu_Speed_UnPin()));

                set => _condensorlabelImgSpeed_clicked = value;
            }


            public ICommand CondensorMenuTemperatureClicked                                 //Condensor Temperature Pin Click Property Calling CondensorMenu_Temperature_Pin() Method using Relay Command
            {
                get => _condensorTemperatureClicked ?? (_condensorTemperatureClicked = new RelayCommand(x => CondensorMenu_Temperature_Pin()));

                set => _condensorTemperatureClicked = value;
            }

            public ICommand CondensorMenuLabelImgTemperature_clicked                        //Condensor Temperature UnPin Click Property Calling CondensorMenu_Temperature_UnPin() Method using Relay Command
            {
                get => _condensorlabelImgTemperature_clicked ?? (_condensorlabelImgTemperature_clicked = new RelayCommand(x => CondensorMenu_Temperature_UnPin()));

                set => _condensorlabelImgTemperature_clicked = value;
            }

            public ICommand CondensorChanged                                                //Condensor Menu Open Property Calling CondensorMenuOpen() Method using Relay Command
        {
                get => _condensorChanged ?? (_condensorChanged = new RelayCommand(x => CondensorChangedMethod()));

                set => _condensorChanged = value;
            }

        #endregion

        /// <summary>
        /// Handles mouse hover event on Condensor Component when user hovers. Attempts displaying Condensor components menu 
        /// </summary>
        private static void DisplayCondensorComponentMenu()                                             //Condensor Menu Open Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            try
            {
                //if (mainWindow.vaccumMenu.IsOpen == false && mainWindow.generatorMenu.IsOpen == false && mainWindow.turbineMenu.IsOpen == false)
                {
                    var powerPlantComponents = from component in db.PowerPlantComponents
                              where component.ComponentID == 2
                              select component;
                    foreach (var item in powerPlantComponents)
                    {
                        mainWindow.condensorMenuitemName.Header         = "Name : " + item.ComponentName;
                        mainWindow.condensorMenuPower.Header            = "Power : " + item.Power;
                        mainWindow.condensorMenuPowerTxt.Text           = item.Power;
                        mainWindow.condensorMenuPressure.Header         = "Pressure : " + item.Pressure;
                        mainWindow.condensorMenuPressureTxt.Text        = item.Pressure;
                        mainWindow.condensorMenuSpeed.Header            = "Speed : " + item.Speed;
                        mainWindow.condensorMenuSpeedTxt.Text           = item.Speed;
                        mainWindow.condensorMenuTemperature.Header      = "Temperature : " + item.Temperature;
                        mainWindow.condensorMenuTemperatureTxt.Text     = item.Temperature;
                    }

                    mainWindow.condensorMenu.IsOpen = true;
                    IsDialogDisplayed = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Loading Condensor component Data from Database");
            }
        }

        private static void CondensorMenuClose()                                            //Condensor Menu Close Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.condensorMenu.IsOpen = false;
            IsDialogDisplayed = false;
        }

        private static void CondensorMenu_Name_Pin()                                         //Condensor Menu Name Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.condensorNamePin.Visibility = Visibility.Hidden;
            mainWindow.condensorMenuitemName_prop_img.Visibility = Visibility.Visible;
            mainWindow.condensorMenuitemName_prop.Content = mainWindow.condensorMenuitemName.Header;
        }

        private static void CondensorMenu_Name_UnPin()                                       //Condensor Menu Name Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.condensorMenuitemName_prop_img.Visibility = Visibility.Hidden;
                mainWindow.condensorNamePin.Visibility = Visibility.Visible;
                mainWindow.condensorMenuitemName_prop.Content = "";
            }
        }

        private static void CondensorMenu_Power_Pin()                                        //Condensor Menu Power Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.condensorPowerPin.Visibility = Visibility.Hidden;
            mainWindow.condensorMenuPower_prop_img.Visibility = Visibility.Visible;
            mainWindow.condensorMenuPower_prop.Content = mainWindow.condensorMenuPower.Header;
        }

        private static void CondensorMenu_Power_UnPin()                                      //Condensor Menu Power Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.condensorMenuPower_prop_img.Visibility = Visibility.Hidden;
                mainWindow.condensorPowerPin.Visibility = Visibility.Visible;
                mainWindow.condensorMenuPower_prop.Content = "";
            }
        }

        private static void CondensorMenu_Pressure_Pin()                                     //Condensor Menu Pressure Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.condensorPressurePin.Visibility = Visibility.Hidden;
            mainWindow.condensorMenuPressure_prop_img.Visibility = Visibility.Visible;
            mainWindow.condensorMenuPressure_prop.Content = mainWindow.condensorMenuPressure.Header;
        }

        private static void CondensorMenu_Pressure_UnPin()                                   //Condensor Menu Pressure Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.condensorMenuPressure_prop_img.Visibility = Visibility.Hidden;
                mainWindow.condensorPressurePin.Visibility = Visibility.Visible;
                mainWindow.condensorMenuPressure_prop.Content = "";
            }
        }

        private static void CondensorMenu_Speed_Pin()                                        //Condensor Menu Speed Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.condensorSpeedPin.Visibility = Visibility.Hidden;
            mainWindow.condensorMenuSpeed_prop_img.Visibility = Visibility.Visible;
            mainWindow.condensorMenuSpeed_prop.Content = mainWindow.condensorMenuSpeed.Header;
        }

        private static void CondensorMenu_Speed_UnPin()                                      //Condensor Menu Speed Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.condensorMenuSpeed_prop_img.Visibility = Visibility.Hidden;
                mainWindow.condensorSpeedPin.Visibility = Visibility.Visible;
                mainWindow.condensorMenuSpeed_prop.Content = "";
            }
        }

        private static void CondensorMenu_Temperature_Pin()                                  //Condensor Menu Temperature Pining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.condensorTemperaturePin.Visibility = Visibility.Hidden;
            mainWindow.condensorMenuTemperature_prop_img.Visibility = Visibility.Visible;
            mainWindow.condensorMenuTemperature_prop.Content = mainWindow.condensorMenuTemperature.Header;
        }

        private static void CondensorMenu_Temperature_UnPin()                                //Condensor Menu Temp[erature Unpining Method
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(IsDialogDisplayed == false)
            {
                mainWindow.condensorMenuTemperature_prop_img.Visibility = Visibility.Hidden;
                mainWindow.condensorTemperaturePin.Visibility = Visibility.Visible;
                mainWindow.condensorMenuTemperature_prop.Content = "";
            }
        }

        private static void CondensorChangedMethod()
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            try
            {
                PowerPlantComponent component = db.PowerPlantComponents.Find(2);
                component.Power = mainWindow.condensorMenuPowerTxt.Text.ToString();
                component.Pressure = mainWindow.condensorMenuPressureTxt.Text.ToString();
                component.Speed = mainWindow.condensorMenuSpeedTxt.Text.ToString();
                component.Temperature = mainWindow.condensorMenuTemperatureTxt.Text.ToString();
                db.SaveChanges();
                DisplayCondensorComponentMenu();
                if (mainWindow.condensorMenuPower_prop_img.IsVisible)
                {
                    CondensorMenu_Power_Pin();
                }
                if (mainWindow.condensorMenuPressure_prop_img.IsVisible)
                {
                    CondensorMenu_Pressure_Pin();
                }
                if (mainWindow.condensorMenuSpeed_prop_img.IsVisible)
                {
                    CondensorMenu_Speed_Pin();
                }
                if (mainWindow.condensorMenuTemperature_prop_img.IsVisible)
                {
                    CondensorMenu_Temperature_Pin();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        #endregion
    }
}