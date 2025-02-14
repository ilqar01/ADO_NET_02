using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForGithub03.Entities;
using ForGithub03.DataAccess;

namespace ForGithub03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // SQL Sunucu ve Veritabanı ismi
                SqlUnitOfWork db = new SqlUnitOfWork("localhost", "LearnCell");
                Customer customer = new Customer();

                Console.WriteLine("1 for adding new customer");
                Console.WriteLine("2 for getting customer list");

                string choice = Console.ReadLine();



                if (choice == "1")
                {
                    Console.WriteLine("Please enter the customer's name: ");
                    customer.Name = Console.ReadLine();
                    Console.WriteLine("Please enter the customer's surname: ");
                    customer.Surname = Console.ReadLine();

                    // Müşteri ekleniyor
                    int id = db.Customers.AddCustomers(customer);
                    Console.WriteLine($"Customer added successfully with ID: {id}");
                }


                else if (choice == "2")
                {
                    // Tüm müşterileri getir
                    List<Customer> customers = db.Customers.GetCustomers();

                        Console.WriteLine("Customer List:");
                        foreach (Customer customer1 in customers)
                        {
                            Console.WriteLine($"ID: {customer1.Id}, Name: {customer1.Name}, Surname: {customer1.Surname}");
                        }
                    
                }
               
            }
        }

    }

