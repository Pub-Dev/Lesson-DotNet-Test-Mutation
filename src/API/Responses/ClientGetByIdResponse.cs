﻿using PubDev.Store.API.Entities;

namespace PubDev.Store.API.Responses;

public class ClientGetByIdResponse
{
    public int ClientId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }

    public static explicit operator ClientGetByIdResponse(Client client)
    {
        return new()
        {
            ClientId = client.ClientId,
            Name = client.Name,
            CreatedDate = client.CreateDate
        };
    }
}
