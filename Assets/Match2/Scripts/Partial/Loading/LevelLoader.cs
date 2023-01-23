using Cysharp.Threading.Tasks;
using Match2.Partial.Scopes;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VContainer.Unity;

namespace Match2.Partial.Loading
{
    public class LevelLoader
    {
        private readonly LifetimeScope currentScope;
        private LevelLifetimeScope levelLifetimeScope;

        private GameObject lifetimeScopePrefab;

        public LevelLoader(LifetimeScope lifetimeScope)
        {
            currentScope = lifetimeScope;
        }

        public async UniTask Load()
        {
            lifetimeScopePrefab = await Addressables.InstantiateAsync("LevelLifetimeScope");
            var instance = lifetimeScopePrefab.GetComponent<LevelLifetimeScope>();
            levelLifetimeScope = currentScope.CreateChildFromPrefab(
                instance);
        }

        public void Unload()
        {
            levelLifetimeScope.Dispose();
            Addressables.ReleaseInstance(lifetimeScopePrefab);
        }
    }
}
