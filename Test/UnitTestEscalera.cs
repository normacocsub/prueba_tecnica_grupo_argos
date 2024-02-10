

namespace Test;

public class UnitTestEscalera(ITestOutputHelper testOutputHelper)
{
    public ITestOutputHelper TestOutputHelper { get; } = testOutputHelper;

    [Fact]
    public async Task GetStairCase()
    {
        // Arrange
        var service = EscaleraService();
        const int number = 5;

        
        // Act
        var response = await service.GetStairCase(number);

        // Assert
        Assert.True(response.IsSuccess);
        Assert.Equal(200, response.StatusCode);
        Assert.NotNull(response.Data);
    }

    [Fact]
    public async Task GetStairInvertCase()
    {
        // Arrange
        var service = EscaleraService();
        const int number = 5;
        
        // Act
        var response = await service.GetStairInvertCase(number);
        
        // Assert
        Assert.True(response.IsSuccess);
        Assert.Equal(200, response.StatusCode);
        Assert.NotNull(response.Data);
    }
    
    [Fact]
    public async Task GetStairRomboCase()
    {
        // Arrange
        var service = EscaleraService();
        const int number = 5;
        
        // Act
        var response = await service.GetStairRomboCase(number);
        
        // Assert
        Assert.True(response.IsSuccess);
        Assert.Equal(200, response.StatusCode);
        Assert.NotNull(response.Data);
    }
    

    private static IEscaleraService EscaleraService()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IEscaleraService, EscaleraService>();


        var classResponseMock = new Mock<IClassResponse<string>>();
        classResponseMock.Setup(m => m.SetSuccess(It.IsAny<string>(), It.IsAny<int>()))
            .Returns((string data, int statusCode) => new ClassResponse<string>
            {
                Data = data,
                StatusCode = statusCode,
                IsSuccess = true
            });
        services.AddSingleton(classResponseMock.Object);

        var serviceProvider = services.BuildServiceProvider();

        var service = serviceProvider.GetRequiredService<IEscaleraService>();
        return service;
    }
}