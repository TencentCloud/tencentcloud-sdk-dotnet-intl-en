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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserBindWorkloadGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The user information of the resource group needs to be bound. If an account has information of multiple hosts, all information needs to be uploaded.
        /// </summary>
        [JsonProperty("BindUsers")]
        public BindUser[] BindUsers{ get; set; }

        /// <summary>
        /// Name of the resource group bound before modification
        /// </summary>
        [JsonProperty("OldWorkloadGroupName")]
        public string OldWorkloadGroupName{ get; set; }

        /// <summary>
        /// Name of the resource group bound after modification
        /// </summary>
        [JsonProperty("NewWorkloadGroupName")]
        public string NewWorkloadGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "BindUsers.", this.BindUsers);
            this.SetParamSimple(map, prefix + "OldWorkloadGroupName", this.OldWorkloadGroupName);
            this.SetParamSimple(map, prefix + "NewWorkloadGroupName", this.NewWorkloadGroupName);
        }
    }
}

