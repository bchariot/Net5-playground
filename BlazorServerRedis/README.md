Docker Commands
    
    Create redis image and container "my-redis" in docker with port 5002:
    C:\Net5.0\NetApp>docker run --name my-redis -p 5002:6379 -d redis

    Run interactive shell for container "my-redis":
    C:\Net5.0\NetApp>docker exec -it my-redis sh
    #

    Run redis command line iterface:
    # redis-cli
    127.0.0.1:6379>

    Get keys and values in list:
    127.0.0.1:6379> scan 0
    1) "0"
    2) 1) "RedisDemo_WeatherForecast_201211_0909"

    Get contents of array "RedisDemo_WeatherForecast_201211_0909":
    127.0.0.1:6379> hgetall RedisDemo_WeatherForecast_201211_0909

    Exit out of cli:
    127.0.0.1:6379> exit
    #

    Exit out of shell:
    # exit

    Get list of docker containers:
    C:\Net5.0\NetApp>docker ps -a
    CONTAINER ID   IMAGE     COMMAND                  CREATED             STATUS             PORTS                    NAMES
    02af15c1a2e8   redis     "docker-entrypoint.s…"   About an hour ago   Up About an hour   0.0.0.0:5002->6379/tcp   my-redis

    Stop container:
    C:\Net5.0\NetApp>docker stop 02af15c1a2e8
    Remove container:
    C:\Net5.0\NetApp>docker rm 02af15c1a2e8

    Get list of docker images:
    C:\Net5.0\NetApp>docker images
    REPOSITORY   TAG       IMAGE ID       CREATED       SIZE
    redis        latest    74d107221092   3 weeks ago   104MB

    Remove docker image:
    C:\Net5.0\NetApp>docker rmi 74d107221092



In Startup.cs:

        public void ConfigureServices(IServiceCollection services)
        {
            ...

            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = Configuration.GetConnectionString("Redis");
                options.InstanceName = "RedisDemo_";
            });
        }


Using NuGet, install packages:
    Microsoft.Extensions.Caching.StackExchange.Redis
    StackExchange.Redis

Create "Extensions" folder, create class: "DistributedClassExtensions"

Add to appsettings.json to connect to local docker:
  "ConnectionStrings": {
    "Redis": "localhost:5002"
  }


