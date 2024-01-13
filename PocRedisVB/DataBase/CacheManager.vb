Imports StackExchange.Redis

Public Class CacheManager
    Private ReadOnly _redisConnection As ConnectionMultiplexer

    Public Sub New(connectionString As String)
        _redisConnection = ConnectionMultiplexer.Connect(connectionString)
    End Sub

    Public Function GetCachedData(key As String) As String
        Dim redisDB As IDatabase = _redisConnection.GetDatabase()
        Return redisDB.StringGet(key)
    End Function

    Public Sub CacheData(key As String, data As String, expiration As TimeSpan)
        Dim redisDB As IDatabase = _redisConnection.GetDatabase()
        redisDB.StringSet(key, data, expiration)
    End Sub
End Class
