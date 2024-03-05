server/run:
	dotnet run --project GrpcGreeter.Server

client/run:
	dotnet run --project GrpcGreeter.Client

web/run:
	dotnet run --project GrpcGreeter.Web

web/hot:
	dotnet watch run --project GrpcGreeter.Web

