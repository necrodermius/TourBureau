using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace View.ViewModels;
public partial class MainViewModel : ObservableObject
{
    private readonly DBContext context;

    [ObservableProperty]
    private IEnumerable<Client> clients;
    [ObservableProperty]
    private IEnumerable<Operator> operators;
    [ObservableProperty]
    private IEnumerable<Hotel> hotels;
    [ObservableProperty]
    private IEnumerable<Tour> tours;
    [ObservableProperty]
    private IEnumerable<Statement> statements;

    public MainViewModel()
    {
        context = new();

        context.Database.Migrate();

        Clients = context.Clients.ToList();
        Operators = context.Operators.ToList();
        Hotels = context.Hotels.ToList();
        Tours = context.Tours.Include(t => t.Operator).Include(t => t.Hotel).ToList();
        Statements = context.Statements.Include(s => s.Client).Include(s => s.Tour).ToList();
    }
}