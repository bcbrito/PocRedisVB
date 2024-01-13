Module Program
    Sub Main()
        ' Substitua "HOST_NAME:PORT_NUMBER,password=PASSWORD" pela string de conexão do seu servidor Redis.
        Dim redisConnectionString As String = "localhost:6379,password=123456"

        ' Criar uma instância do gerenciador de cache.
        Dim cacheManager As New CacheManager(redisConnectionString)

        ' Exemplo: Armazenar um valor no cache.
        cacheManager.CacheData("exemplo_chave", "exemplo_valor", TimeSpan.FromMinutes(10))

        ' Exemplo: Recuperar um valor do cache.
        Dim valorRecuperado As String = cacheManager.GetCachedData("exemplo_chave")
        Console.WriteLine($"Valor recuperado do Redis: {valorRecuperado}")
    End Sub
End Module