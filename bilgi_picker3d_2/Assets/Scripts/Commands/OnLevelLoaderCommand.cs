using Interfaces;
using UnityEngine;
using ICommand = System.Windows.Input.ICommand;

namespace Command
{
    public class OnLevelLoaderCommand : ICommand
    {
        private Transform _levelHolder;

        public OnLevelLoaderCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }

        public void Execute()
        {
        }

        public void Execute(int levelID)
        {
            Object.Instantiate(Resources.Load<GameObject>($"Prefabs/LevelPrefabs/level{levelID}"), _levelHolder);
        }
    }
}