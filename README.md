# Runes API (.NET)

.NET based API for transforming text to runes.

### Run in docker

```
docker build runes-api-dotnet .
docker run -p 5000:80 runes-api-dotnet
```

Navigate to
`http://localhost:5000/api/younger-futhark/your-content-string-here`
`http://localhost:5000/api/elder-futhark/your-content-string-here`
`http://localhost:5000/api/medieval-futhork/your-content-string-here`
`http://localhost:5000/api/futhorc/your-content-string-here`