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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUserRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// RoleArn info
        /// </summary>
        [JsonProperty("Arn")]
        public string Arn{ get; set; }

        /// <summary>
        /// Role description
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Role name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Authorized path list in cos
        /// </summary>
        [JsonProperty("CosPermissionList")]
        public CosPermission[] CosPermissionList{ get; set; }

        /// <summary>
        /// cam policy json
        /// </summary>
        [JsonProperty("PermissionJson")]
        public string PermissionJson{ get; set; }

        /// <summary>
        /// Whether resident is set to: 1 non-resident (default), 2 resident (only able to set one resident).
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Arn", this.Arn);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "CosPermissionList.", this.CosPermissionList);
            this.SetParamSimple(map, prefix + "PermissionJson", this.PermissionJson);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
        }
    }
}

