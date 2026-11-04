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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetStatisticDataByNameRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Device name. If no device is specified, you can pass "-1"</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>Start time of statistics, unit: s</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// <p>Statistics end time, unit: s</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>Time granularity</p><p>Enumeration values:</p><ul><li>1: hourly statistics</li><li>2: daily statistics</li><li>3: per minute</li><li>4: every 5 minutes</li></ul>
        /// </summary>
        [JsonProperty("TimeGranularity")]
        public long? TimeGranularity{ get; set; }

        /// <summary>
        /// <p>Access region. Value range: ['MC','AP','EU','AM'] MC=Chinese mainland AP=Asia Pacific EU=Europe AM=Americas. If not specified, it represents all regions.</p>
        /// </summary>
        [JsonProperty("AccessRegion")]
        public string AccessRegion{ get; set; }

        /// <summary>
        /// <p>Gateway type. 0: public cloud gateway; 1: private gateway. Defaults to 0 if not passed.</p>
        /// </summary>
        [JsonProperty("GatewayType")]
        public long? GatewayType{ get; set; }

        /// <summary>
        /// <p>Device name list, up to 10 devices. Used when downloading traffic for multiple devices. At this point, DeviceName can be set to "-1"</p>
        /// </summary>
        [JsonProperty("DeviceList")]
        public string[] DeviceList{ get; set; }

        /// <summary>
        /// <p>Device group ID. Do not pass it if no group is specified. Used when downloading data by group</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>Application ID. If not specified, leave it blank. Used when downloading data by application</p>
        /// </summary>
        [JsonProperty("MpApplicationId")]
        public string MpApplicationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TimeGranularity", this.TimeGranularity);
            this.SetParamSimple(map, prefix + "AccessRegion", this.AccessRegion);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamArraySimple(map, prefix + "DeviceList.", this.DeviceList);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "MpApplicationId", this.MpApplicationId);
        }
    }
}

