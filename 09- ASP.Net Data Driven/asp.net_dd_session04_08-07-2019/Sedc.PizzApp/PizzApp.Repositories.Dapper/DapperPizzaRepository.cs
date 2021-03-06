﻿using PizzApp.Models;
using PizzApp.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace PizzApp.Repositories.Dapper
{
    public class DapperPizzaRepository : IPizzaRepository
    {
        private readonly string connectionString = string.Empty;
        public DapperPizzaRepository(string connectionString)
        {

        }
        public void AddPrice(PizzaPrice pizzaPrice)
        {
            throw new NotImplementedException();
        }

        public Pizza Create(Pizza model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetAllPizzas()
        {
            using (var connection  = new SqlConnection(connectionString))
            {
                var query = "select * from Pizzas";
                var pizzas = connection.Query<Pizza>(query);
                return pizzas.ToList();
            }
        }

        public Pizza GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Pizza Update(Pizza model)
        {
            throw new NotImplementedException();
        }
    }
}
