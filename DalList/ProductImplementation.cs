namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using System;
using System.Reflection;
using Tools;

internal class ProductImplementation : IProduct
{
    string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName!;
    public int Create(Product item)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;


        LogManager.WriteToLog(projectName, $"Starting function {functionName}");

        try
        {
            var isExist = DataSource.products.FirstOrDefault(p => p.Id == item.Id);
            if (isExist != null)
            {
                throw new dal_idIdExist("The product already exists");
            }
            else
            {
                DataSource.products.Add(item with { Id = DataSource.Config.ProductCode });
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
            Product p = Read(id);
            DataSource.products.Remove(p);

            LogManager.WriteToLog(projectName, $"Product with ID: {id} deleted successfully");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

    public Product? Read(int id)
    {  

        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName} with ID: {id}");

        try
        {
            var isExist = DataSource.products.FirstOrDefault(c => c.Id == id);


            if (isExist == null)
            {
                throw new dal_objcectNotFound("The product was not found");
            }

            LogManager.WriteToLog(projectName, $"Product with ID: {id} read successfully");
            return isExist;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

    public Product? Read(Func<Product, bool> filter)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName} with filter");

        try
        {
            var data = DataSource.products.FirstOrDefault(p => filter(p));
            if (data == null)
            {
                throw new dal_objcectNotFound("The product was not found");
            }

            LogManager.WriteToLog(projectName, $"Product read successfully with filter");
            return data;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName} with filter");

        try
        {
            var data = from p in DataSource.products
                       where filter == null || filter(p)
                       select p;

            LogManager.WriteToLog(projectName, $"Read all products successfully");
            return data.ToList();
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

    public void Update(Product item)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName} with ID: {item.Id}");

        try
        {
            Delete(item.Id);
            DataSource.products.Add(item);

            LogManager.WriteToLog(projectName, $"Product with ID: {item.Id} updated successfully");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: {ex.Message}");
            throw;
        }
    }

}
