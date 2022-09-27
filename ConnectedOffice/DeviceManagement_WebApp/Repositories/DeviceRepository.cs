using DeviceManagement_WebApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using DeviceManagement_WebApp.Models;



public class DeviceRepository
{
    protected readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

    protected ConnectedOfficeContext Context => _context;

    // GET ALL: Devices
    public List<Device> GetAll()
    {
        return Context.Device.ToList();
    }

    // TO DO: Add ‘Get By Id’
    // TO DO: Add ‘Create’
    // TO DO: Add ‘Edit’
    // TO DO: Add ‘Delete’
    // TO DO: Add ‘Exists’

}


