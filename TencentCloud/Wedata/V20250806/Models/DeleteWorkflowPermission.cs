/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteWorkflowPermission : AbstractModel
    {
        
        /// <summary>
        /// Target type to delete (user: user, role: role, group: group).
        /// </summary>
        [JsonProperty("PermissionTargetType")]
        public string PermissionTargetType{ get; set; }

        /// <summary>
        /// Authorization target id (userId/roleId) to delete.
        /// </summary>
        [JsonProperty("PermissionTargetId")]
        public string PermissionTargetId{ get; set; }

        /// <summary>
        /// Type array of authorization permissions to delete (CAN_VIEW/CAN_RUN/CAN_EDIT/CAN_MANAGE, currently only support CAN_MANAGE).
        /// </summary>
        [JsonProperty("PermissionTypeList")]
        public string[] PermissionTypeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PermissionTargetType", this.PermissionTargetType);
            this.SetParamSimple(map, prefix + "PermissionTargetId", this.PermissionTargetId);
            this.SetParamArraySimple(map, prefix + "PermissionTypeList.", this.PermissionTypeList);
        }
    }
}

