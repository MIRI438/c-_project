namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using System;
using System.Linq; 
using System.Reflection;
using Tools;

internal class CustomerImplementation : ICustomer
{
    string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName!;
    public int Create(Customer item)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;


        LogManager.WriteToLog(projectName, $"Starting function {functionName}");

        try
        {
            var isExist = DataSource.customers.FirstOrDefault(c => c.Id == item.Id);
            if (isExist != null)
            {
                throw new dal_idIdExist("The customer already exists");
            }
            else
            {
                DataSource.customers.Add(item);
            }


            LogManager.WriteToLog(projectName, $"Customer created successfully with ID: {item.Id}");
            return item.Id;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

    public void Delete(int id)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;


        LogManager.WriteToLog(projectName, $"Starting function {functionName} with ID: {id}");

        try
        {
            Customer c = Read(id);
            DataSource.customers.Remove(c);

            LogManager.WriteToLog(projectName, $"Customer with ID: {id} deleted successfully");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

    public Customer? Read(int id)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;


        LogManager.WriteToLog(projectName, $"Starting function {functionName} with ID: {id}");

        try
        {
            var isExist = DataSource.customers.FirstOrDefault(c => c.Id == id);
            if (isExist == null)
            {
                throw new dal_idIdExist("The customer was not found");
            }

            LogManager.WriteToLog(projectName, $"Customer with ID: {id} read successfully");
            return isExist;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {

        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName} with filter");

        try
        {
            var data = DataSource.customers.FirstOrDefault(c => filter(c));
            if (data == null)
            {
                throw new dal_objcectNotFound("The customer was not found");
            }

            LogManager.WriteToLog(projectName, $"Customer read successfully with filter");
            return data;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;


        LogManager.WriteToLog(projectName, $"Starting function {functionName} with filter");

        try
        {
            var data = from c in DataSource.customers
                       where filter == null || filter(c)
                       select c;

            LogManager.WriteToLog(projectName, $"Read all customers successfully");
            return data.ToList();
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

    public void Update(Customer item)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;


        LogManager.WriteToLog(projectName, $"Starting function {functionName} with ID: {item.Id}");

        try
        {
            Delete(item.Id);
            DataSource.customers.Add(item);

            LogManager.WriteToLog(projectName, $"Customer with ID: {item.Id} updated successfully");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }
}
