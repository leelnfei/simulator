/**
 * Copyright (c) 2019 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using SimpleJSON;
using UnityEngine;

namespace Simulator.Api.Commands
{
    class VehicleApplyNPCControl : ICommand
    {
        public string Name { get { return "vehicle/apply_npc_control"; } }

        public void Execute(JSONNode args)
        {
            var uid = args["uid"].Value;
            var api = SimulatorManager.Instance.ApiManager;

            if (api.Agents.TryGetValue(uid, out GameObject obj))
            {
                var control = args["control"];

                var npc = obj.GetComponent<NPCController>();
                if (npc == null)
                {
                    api.SendError($"Agent '{uid}' is not a NPC agent");
                    return;
                }

                if (control["headlights"] != null)
                {
                    int headlights = control["headlights"].AsInt;
                    npc.SetLights(headlights);
                }

                if (control["hazards"] != null)
                {
                    bool hazards = control["hazards"].AsBool;
                    npc.SetNPCHazards(hazards);
                }

                if (control["e_stop"] != null)
                {
                    bool e_stop = control["e_stop"].AsBool;
                    npc.ForceEStop(e_stop);
                }

                if (control["isLeftTurnSignal"] != null || control["isRightTurnSignal"] != null)
                {
                    bool isLeftTurnSignal = control["isLeftTurnSignal"].AsBool;
                    bool isRightTurnSignal = control["isRightturnSignal"].AsBool;
                    npc.SetNPCTurnSignal(true, isLeftTurnSignal, isRightTurnSignal);
                }
                api.SendResult();
            }
            else
            {
                api.SendError($"Agent '{uid}' not found");
            }
        }
    }
}