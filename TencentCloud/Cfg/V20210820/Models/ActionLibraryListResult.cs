/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActionLibraryListResult : AbstractModel
    {
        
        /// <summary>
        /// Action name
        /// </summary>
        [JsonProperty("ActionName")]
        public string ActionName{ get; set; }

        /// <summary>
        /// Action description
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Action type: ["platform" and "custom"]
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Creator
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Action risk description
        /// </summary>
        [JsonProperty("RiskDesc")]
        public string RiskDesc{ get; set; }

        /// <summary>
        /// Action ID
        /// </summary>
        [JsonProperty("ActionId")]
        public ulong? ActionId{ get; set; }

        /// <summary>
        /// Action attribute (1: fault; 2: recovery)
        /// </summary>
        [JsonProperty("AttributeId")]
        public ulong? AttributeId{ get; set; }

        /// <summary>
        /// ID of the associated action
        /// </summary>
        [JsonProperty("RelationActionId")]
        public ulong? RelationActionId{ get; set; }

        /// <summary>
        /// Operation command
        /// </summary>
        [JsonProperty("ActionCommand")]
        public string ActionCommand{ get; set; }

        /// <summary>
        /// Action type (0: tat; 1: cloud API)
        /// </summary>
        [JsonProperty("ActionCommandType")]
        public ulong? ActionCommandType{ get; set; }

        /// <summary>
        /// Parameters of the custom action, in JSON string format
        /// </summary>
        [JsonProperty("ActionContent")]
        public string ActionContent{ get; set; }

        /// <summary>
        /// Level-2 type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Action description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionDetail")]
        public string ActionDetail{ get; set; }

        /// <summary>
        /// Whether to allow usage by the current account
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsAllowed")]
        public bool? IsAllowed{ get; set; }

        /// <summary>
        /// Link to best practices
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionBestCase")]
        public string ActionBestCase{ get; set; }

        /// <summary>
        /// Object type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// Monitoring metric ID list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetricIdList")]
        public ulong?[] MetricIdList{ get; set; }

        /// <summary>
        /// Whether the action is new
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsNewAction")]
        public bool? IsNewAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActionName", this.ActionName);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RiskDesc", this.RiskDesc);
            this.SetParamSimple(map, prefix + "ActionId", this.ActionId);
            this.SetParamSimple(map, prefix + "AttributeId", this.AttributeId);
            this.SetParamSimple(map, prefix + "RelationActionId", this.RelationActionId);
            this.SetParamSimple(map, prefix + "ActionCommand", this.ActionCommand);
            this.SetParamSimple(map, prefix + "ActionCommandType", this.ActionCommandType);
            this.SetParamSimple(map, prefix + "ActionContent", this.ActionContent);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ActionDetail", this.ActionDetail);
            this.SetParamSimple(map, prefix + "IsAllowed", this.IsAllowed);
            this.SetParamSimple(map, prefix + "ActionBestCase", this.ActionBestCase);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamArraySimple(map, prefix + "MetricIdList.", this.MetricIdList);
            this.SetParamSimple(map, prefix + "IsNewAction", this.IsNewAction);
        }
    }
}

