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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListRecordPlanDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cloud migration plan ID
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// Maximum number of items per page.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Which page.
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// Query by device name. If it is empty, ignore this parameter.
        /// Only one of the channel name, device name, and organization name is valid at the same time. If multiple fields have values at the same time, query by the priority order of channel name, device name, and organization name. If all are empty, perform a full query. The length cannot exceed 32 bytes.
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// Query by channel name. If it is empty, ignore this parameter.
        /// Only one of the channel name, device name, and organization name is valid at the same time. If multiple fields have values at the same time, query by the priority order of channel name, device name, and organization name. If all are empty, perform a full query. The length cannot exceed 32 bytes.
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// Query by organization name. If it is empty, ignore this parameter.
        /// Only one of the channel name, device name, and organization name is valid at the same time. If multiple fields have values at the same time, query by the priority order of channel name, device name, and organization name. If all are empty, perform a full query. The length cannot exceed 32 bytes.
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
        }
    }
}

