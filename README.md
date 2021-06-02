# Deploying .Net Microservices to Azure Kubernetes Services(AKS) and Automating with Azure DevOps
Deploying .Net Microservices into Kubernetes, and moving deployments to the cloud Azure Kubernetes Services (AKS) with using Azure Container Registry (ACR) and how to Automating Deployments with Azure DevOps and GitHub.

## UI Look and Feel

![Web API Output|150x150](./documentation/images/UILookAndFeel.PNG)


```
docker login

docker tag docker-image-id vishipayyallore/shoppingapp

docker push vishipayyallore/shoppingapp:latest
```

Staying inside the **D:\LordKrishna\GitHub\shopping-devops\shopping>** folder

```
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up

docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down
```

To get list of container id which are currently running
```
docker ps -aq 
```

