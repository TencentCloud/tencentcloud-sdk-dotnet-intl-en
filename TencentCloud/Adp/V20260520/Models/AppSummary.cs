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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>Application ID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Application mode. Enumeration values: 1: standard mode, 2: Agent mode, 3: single workflow mode, 4: ClawAgent mode</p>
        /// </summary>
        [JsonProperty("AppMode")]
        public long? AppMode{ get; set; }

        /// <summary>
        /// <p>Application avatar</p>
        /// </summary>
        [JsonProperty("Avatar")]
        public string Avatar{ get; set; }

        /// <summary>
        /// <p>Application name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Operation information</p>
        /// </summary>
        [JsonProperty("OperationInfo")]
        public AppOperation OperationInfo{ get; set; }

        /// <summary>
        /// <p>Status information</p>
        /// </summary>
        [JsonProperty("Status")]
        public AppStatusInfo Status{ get; set; }

        /// <summary>
        /// <p>Sub-status information</p>
        /// </summary>
        [JsonProperty("SubStatus")]
        public AppSubStatusInfo SubStatus{ get; set; }

        /// <summary>
        /// <p>Resource operation permissions</p>
        /// </summary>
        [JsonProperty("PermissionIdList")]
        public string[] PermissionIdList{ get; set; }

        /// <summary>
        /// <p>Application description information</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AppMode", this.AppMode);
            this.SetParamSimple(map, prefix + "Avatar", this.Avatar);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "OperationInfo.", this.OperationInfo);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamObj(map, prefix + "SubStatus.", this.SubStatus);
            this.SetParamArraySimple(map, prefix + "PermissionIdList.", this.PermissionIdList);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

