FROM microsoft/dotnet

ENV ASPNETCORE_URLS http://*:5000

RUN mkdir -p /webapp/
WORKDIR /webapp/

COPY . /webapp/


RUN ["dotnet","restore"]

RUN ["dotnet","build"]

EXPOSE 5000

ENTRYPOINT ["dotnet","run"]