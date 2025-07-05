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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateGrafanaNotificationChannelRequest : AbstractModel
    {
        
        /// <summary>
        /// Channel ID, such as “nchannel-abcd1234”.
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// TCMG instance ID, such as “grafana-12345678”.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Alert channel name, such as “test”.
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// Array of notification channel IDs
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// This parameter has been deprecated. Please use `OrganizationIds` instead.
        /// </summary>
        [JsonProperty("ExtraOrgIds")]
        public string[] ExtraOrgIds{ get; set; }

        /// <summary>
        /// Array of valid organization IDs
        /// </summary>
        [JsonProperty("OrganizationIds")]
        public string[] OrganizationIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamArraySimple(map, prefix + "Receivers.", this.Receivers);
            this.SetParamArraySimple(map, prefix + "ExtraOrgIds.", this.ExtraOrgIds);
            this.SetParamArraySimple(map, prefix + "OrganizationIds.", this.OrganizationIds);
        }
    }
}

