using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;
using WebProject.Data;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            var vm = new BuyCarViewModel();

            using (DataModel dm = new DataModel())
            {
                foreach (var i in dm.Cars.OrderByDescending(s => s.Year))
                {
                    vm.BuyCars.Add(i);
                }

            }
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel m)
        {
            ViewBag.Title = "Contact";
            if(String.IsNullOrEmpty(m.contact_name))
            {

            }
            else
            {
                int count = 0;
                if (!String.IsNullOrEmpty(m.contact_phone))
                {
                    for (int i = 0; i < m.contact_phone.Length; i++)
                    {
                        if (Char.IsNumber(m.contact_phone[i]))
                        {
                            count++;
                        }

                    }
                }

                String name = m.contact_name.Trim();
                if ((count == 10 && (name.Contains(" ")) || String.IsNullOrEmpty(m.contact_phone) && name.Contains(" ")))
                {
                    return PartialView("ContactAcknowledgement", m);
                }
                if (count < 10 && !name.Contains(" "))
                {
                    ModelState.AddModelError("contact_phone", "The phone number entered is not valid");
                    ModelState.AddModelError("contact_name", "Please enter a first name and last name");
                }
                else if (!name.Contains(" "))
                {
                    ModelState.AddModelError("contact_name", "Please enter a first name and last name");
                }
                else
                {
                    ModelState.AddModelError("contact_phone", "The phone number entered is not valid");
                }
            }

            return PartialView("ContactAcknowledgement", m);
        }

        public ActionResult BuyCar()
        {
            ViewBag.Title = "Buy Car";
            var vm = new BuyCarViewModel();

            using (DataModel dm = new DataModel())
            {
                foreach (var i in dm.Cars.OrderByDescending(s => s.Year))
                {
                    vm.BuyCars.Add(i);
                }
                
            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult BuyCar(BuyCarViewModel vm)
        {
            ViewBag.Title = "Buy Car";

            using (DataModel dm = new DataModel())
            {
                if(vm.sort == null)
                {
                    foreach(var car in dm.Cars)
                    {
                        if(vm.all_makes.Equals("makes") && vm.all_models.Equals("models") && vm.price.Equals(0) && vm.transmission.Equals("manual_automatic"))
                        {
                            vm.BuyCars.Add(car);
                        }
                        else if(vm.all_makes.Equals("makes") && vm.all_models.Equals("models") && vm.price.Equals(0))
                        {
                            if(vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic"))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if(vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))
                            {
                                vm.BuyCars.Add(car);
                            }
                        }
                        else if(vm.all_makes.Equals("makes") && vm.all_models.Equals("models"))
                        {
                            if (vm.price.Equals(5) && car.Price <= 5000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if (vm.price.Equals(10) && car.Price <= 10000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if (vm.price.Equals(15) && car.Price <= 15000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if (vm.price.Equals(20) && car.Price <= 20000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                        }
                        else if((vm.all_makes.Equals("makes") && vm.all_models.Equals(car.Model)))
                        {
                            if (vm.price.Equals(5) && car.Price <= 5000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if (vm.price.Equals(10) && car.Price <= 10000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if (vm.price.Equals(15) && car.Price <= 15000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if (vm.price.Equals(20) && car.Price <= 20000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                        }
                        else if(vm.all_models.Equals("models") && vm.price.Equals(0) && vm.transmission.Equals("manual_automatic"))
                        {
                            if(vm.all_makes.Equals(car.Make))
                            {
                                vm.BuyCars.Add(car);
                            }
                        }
                        else if (vm.all_models.Equals("models") && vm.price.Equals(0))
                        {
                            if (vm.all_makes.Equals(car.Make) && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                        }
                        else if (vm.all_models.Equals("models"))
                        {
                            if (vm.all_makes.Equals(car.Make) && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                if (vm.price.Equals(5) && car.Price <= 5000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                                {
                                    vm.BuyCars.Add(car);
                                }
                                else if (vm.price.Equals(10) && car.Price <= 10000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                                {
                                    vm.BuyCars.Add(car);
                                }
                                else if (vm.price.Equals(15) && car.Price <= 15000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                                {
                                    vm.BuyCars.Add(car);
                                }
                                else if (vm.price.Equals(20) && car.Price <= 20000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                                {
                                    vm.BuyCars.Add(car);
                                }
                            }
                        }
                        else if (vm.price.Equals(0) && vm.transmission.Equals("manual_automatic"))
                        {
                            if(vm.all_makes.Equals(car.Make) && vm.all_models.Equals(car.Model))
                            {
                                vm.BuyCars.Add(car);
                            }
                            
                        }
                        else if (vm.price.Equals(0))
                        {
                            if (vm.all_makes.Equals(car.Make) && vm.all_models.Equals(car.Model) && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                        }
                        else if (vm.transmission.Equals("manual_automatic"))
                        {
                            if (vm.all_makes.Equals(car.Make) && vm.all_models.Equals(car.Model))
                            {
                                if (vm.price.Equals(5) && car.Price <= 5000)
                                {
                                    vm.BuyCars.Add(car);
                                }
                                else if (vm.price.Equals(10) && car.Price <= 10000)
                                {
                                    vm.BuyCars.Add(car);
                                }
                                else if (vm.price.Equals(15) && car.Price <= 15000)
                                {
                                    vm.BuyCars.Add(car);
                                }
                                else if (vm.price.Equals(20) && car.Price <= 20000)
                                {
                                    vm.BuyCars.Add(car);
                                }
                            }

                        }
                        else if (vm.all_makes.Equals(car.Make) && vm.all_models.Equals(car.Model))
                        {
                            if (vm.price.Equals(5) && car.Price <= 5000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if(vm.price.Equals(10) && car.Price <= 10000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if (vm.price.Equals(15) && car.Price <= 15000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }
                            else if (vm.price.Equals(20) && car.Price <= 20000 && ((vm.transmission.Equals("Automatic") && car.Transmission.Equals("Automatic")) || (vm.transmission.Equals("Manual") && car.Transmission.Equals("Manual"))))
                            {
                                vm.BuyCars.Add(car);
                            }

                        }
                        
                        
                    }
                    
                }
                else
                {
                    if (vm.sort.Equals("hprice"))
                    {
                        foreach (var i in dm.Cars.OrderByDescending(s => s.Price))
                        {
                            vm.BuyCars.Add(i);
                        }
                    }
                    else if (vm.sort.Equals("lprice"))
                    {
                        foreach (var i in dm.Cars.OrderByDescending(s => s.Price))
                        {
                            vm.BuyCars.Add(i);
                        }
                        vm.BuyCars.Reverse();
                    }
                    else if (vm.sort.Equals("newest"))
                    {
                        foreach (var i in dm.Cars.OrderByDescending(s => s.Year))
                        {
                            vm.BuyCars.Add(i);
                        }
                    }
                    else if (vm.sort.Equals("oldest"))
                    {
                        foreach (var i in dm.Cars.OrderByDescending(s => s.Year))
                        {
                            vm.BuyCars.Add(i);
                        }
                        vm.BuyCars.Reverse();
                    }
                    else if (vm.sort.Equals("za"))
                    {
                        foreach (var i in dm.Cars.OrderByDescending(s => s.Make))
                        {
                            vm.BuyCars.Add(i);
                        }
                    }
                    else if (vm.sort.Equals("az"))
                    {
                        foreach (var i in dm.Cars.OrderByDescending(s => s.Make))
                        {
                            vm.BuyCars.Add(i);
                        }
                        vm.BuyCars.Reverse();
                    }
                }
            }
            return View(vm);
        }

        public ActionResult SellCar()
        {
            ViewBag.Title = "Sell Car";

            return View();
        }

        [HttpPost]
        public ActionResult SellCar(SellCarViewModel m)
        {
            ViewBag.Title = "Sell Car";

            if (String.IsNullOrEmpty(m.contact_name))
            {

            }
            else
            {
                int count = 0;
                if (!String.IsNullOrEmpty(m.contact_phone))
                {
                    for (int i = 0; i < m.contact_phone.Length; i++)
                    {
                        if (Char.IsNumber(m.contact_phone[i]))
                        {
                            count++;
                        }

                    }
                }

                String name = m.contact_name.Trim();
                if ((count == 10 && (name.Contains(" ")) || String.IsNullOrEmpty(m.contact_phone) && name.Contains(" ")))
                {
                    return RedirectToAction("ContactAcknowledgement");
                }
                if (count < 10 && !name.Contains(" "))
                {
                    ModelState.AddModelError("contact_phone", "The phone number entered is not valid");
                    ModelState.AddModelError("contact_name", "Please enter a first name and last name");
                }
                else if (!name.Contains(" "))
                {
                    ModelState.AddModelError("contact_name", "Please enter a first name and last name");
                }
                else
                {
                    ModelState.AddModelError("contact_phone", "The phone number entered is not valid");
                }
            }


            return View(m);
        }

        public ActionResult ContactAcknowledgement()
        {
            ViewBag.Title = "Contact";
            return View();
        }

        [HttpGet]
        public ActionResult Play()
        {
            var vmTable = new TicTacToeViewModel();

            using (DataModel dm = new DataModel())
            {
                Tables table = (Tables)dm.Tables.FirstOrDefault();

                //Check if there were values in the db
                if(table == null)
                {
                    table = new Tables();
                    table.cell11 = "";
                    table.cell12 = "";
                    table.cell13 = "";
                    table.cell21 = "";
                    table.cell22 = "";
                    table.cell23 = "";
                    table.cell31 = "";
                    table.cell32 = "";
                    table.cell33 = "";
                    dm.Tables.Add(table);
                    vmTable.Table.Add(table);

                }

            }
            return View(vmTable);
        }


        [HttpPost]
        public ActionResult Play(TicTacToeViewModel m)
        {
            var vm = new TicTacToeViewModel();
            if(String.IsNullOrWhiteSpace(vm.cell11))
            {
                using (DataModel dm = new DataModel())
                {
                    foreach (var i in dm.Tables)
                    {
                        vm.Table.Add(i);
                    }
                }
            }
            return View(m);
        }



    }
}