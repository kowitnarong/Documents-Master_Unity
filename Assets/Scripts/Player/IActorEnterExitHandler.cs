using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public interface IActorEnterExitHandler
    {
        void ActorEnter(GameObject actor);
        void ActorExit(GameObject actor);
    }
}