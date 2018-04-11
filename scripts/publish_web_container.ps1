$name = "web"
$repo_name="tripdubroot/{0}:{1}" -f $name, "latest"
$res_group="thinkofusauth"
$container_name="thinkofusweb"

docker build ..\web -t $container_name
docker tag $container_name $repo_name
docker push $repo_name
az group create -n $res_group -l eastus
az container create --name $container_name --image $repo_name --cpu 1 --memory 1 --ip-address public -g $res_group --output json

echo 'Az complete'
