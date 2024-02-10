namespace Test;


public class UnitTestMedia(ITestOutputHelper testOutputHelper)
{
    public ITestOutputHelper TestOutputHelper { get; } = testOutputHelper;

    [Fact]
    public async Task GetMedia()
    {
        // Arrange
        var service = MediaService();
        var numbers = new List<float> { 1, 2, 3, 4, 5 };

        
        // Act
        var response = await service.GetMedia(numbers);

        // Assert
        Assert.True(response.IsSuccess);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public async Task GetMediaArmonica()
    {
        // Arrange
        var service = MediaService();
        var numbers = new List<float> { 1, 2, 3, 4, 5 };
        
        // Act
        var response = await service.GetMediaArmonica(numbers);
        
        // Assert
        Assert.True(response.IsSuccess);
        Assert.Equal(200, response.StatusCode);
    }
    
    [Fact]
    public async Task GetMediana()
    {
        // Arrange
        var service = MediaService();
        var numbers = new List<float> { 1, 2, 3, 4, 5 };
        
        // Act
        var response = await service.GetMediana(numbers);
        
        // Assert
        Assert.True(response.IsSuccess);
        Assert.Equal(200, response.StatusCode);
    }
    

    private static IMediaService MediaService()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IMediaService, MediaService>();


        var classResponseMock = new Mock<IClassResponse<float>>();
        classResponseMock.Setup(m => m.SetSuccess(It.IsAny<float>(), It.IsAny<int>()))
            .Returns((float data, int statusCode) => new ClassResponse<float>
            {
                Data = data,
                StatusCode = statusCode,
                IsSuccess = true
            });
        services.AddSingleton(classResponseMock.Object);

        var serviceProvider = services.BuildServiceProvider();

        var service = serviceProvider.GetRequiredService<IMediaService>();
        return service;
    }
}