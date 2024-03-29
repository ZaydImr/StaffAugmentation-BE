﻿using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

public class TestRequestFormStatusController
{
    private readonly RequestFormStatusController _controller;

    public TestRequestFormStatusController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<RequestFormStatusController>();
        var mockRequestFormStatusService = new Mock<IRequestFormStatusService>();
        mockRequestFormStatusService.Setup(svc => svc.GetRequestFormStatus().Result).Returns(new List<RequestFormStatusViewModel>
            {
                new RequestFormStatusViewModel { Id = "RFS1", Value = "RequestFormStatus 1" },
                new RequestFormStatusViewModel { Id = "RFS2", Value = "RequestFormStatus 2" },
                new RequestFormStatusViewModel { Id = "RFS3", Value = "RequestFormStatus 3" },
            });
        _controller = new RequestFormStatusController(logger, mockRequestFormStatusService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = await _controller.GetAll();

        // Assert
        Assert.IsType<ActionResult<List<RequestFormStatusViewModel>?>?>(result);
    }

    [Fact]
    public async Task GetRequestFormStatus_OnReturnsData()
    {
        // Act
        var result = await _controller.GetRequestFormStatus("RFS1");

        // Assert
        Assert.IsType<ActionResult<RequestFormStatusViewModel?>?>(result);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = await _controller.CreateRequestFormStatus(new RequestFormStatusViewModel { Id = "RFS4", Value = "RequestFormStatus 4" });

        // Assert
        Assert.IsType<ActionResult<RequestFormStatusViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdateRequestFormStatus(new RequestFormStatusViewModel { Id = "RFS4", Value = "RequestFormStatus 4" });

        // Assert
        Assert.IsType<ActionResult<RequestFormStatusViewModel?>>(result);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = await _controller.DeleteRequestFormStatus("RFS4");

        // Assert
        Assert.IsType<ActionResult<List<RequestFormStatusViewModel>>>(result);
    }
}