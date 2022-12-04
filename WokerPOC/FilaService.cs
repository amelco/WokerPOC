﻿using Microsoft.AspNetCore.Mvc;
using WokerPOC;
using WokerPOC.Repositories;

public class FilaService
{
    private readonly CasosRepository _repository;
    private List<Timer> timers;

    public FilaService(CasosRepository repository)
    {
        _repository = repository;
        timers = new();
    }

    public void iniciaFila()
    {
        var casos = _repository.Listar();
        foreach (var caso in casos)
        {
            if (caso.Status != Status.Fechado)
            {
                var tempo = Convert.ToInt32(caso.Previa.Subtract(DateTime.Now).Seconds);
                timers.Add(
                    new Timer(new TimerCallback(EncerraCaso), caso, tempo*1000, Timeout.Infinite)
                );
                Console.WriteLine($"Caso {caso.Id} aberto.");
            }
        }
    }

    private void EncerraCaso(object? caso)
    {
        if (caso is null)
            return;

        var c = ((Caso)caso);
        c.Status = Status.Fechado;
        Console.Write($" Caso {c.Id} encerrado.\n");
        // TODO: remover timer da lista
    }
}