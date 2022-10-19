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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GrafanaNotificationChannel : AbstractModel
    {
        
        /// <summary>
        /// Channel ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// Channel name
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// Array of notification channel template IDs
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// Default valid organization. This parameter has been deprecated. Please use `OrganizationIds` instead.
        /// </summary>
        [JsonProperty("OrgId")]
        public string OrgId{ get; set; }

        /// <summary>
        /// Extra valid organization. This parameter has been deprecated. Please use `OrganizationIds` instead.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtraOrgIds")]
        public string[] ExtraOrgIds{ get; set; }

        /// <summary>
        /// Valid organization. This parameter has been deprecated. Please use `OrganizationIds` instead.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgIds")]
        public string OrgIds{ get; set; }

        /// <summary>
        /// All valid organizations in an alert channel
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrganizationIds")]
        public string OrganizationIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamArraySimple(map, prefix + "Receivers.", this.Receivers);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamArraySimple(map, prefix + "ExtraOrgIds.", this.ExtraOrgIds);
            this.SetParamSimple(map, prefix + "OrgIds", this.OrgIds);
            this.SetParamSimple(map, prefix + "OrganizationIds", this.OrganizationIds);
        }
    }
}

