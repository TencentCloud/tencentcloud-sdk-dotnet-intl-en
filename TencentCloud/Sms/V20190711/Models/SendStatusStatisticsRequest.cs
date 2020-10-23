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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendStatusStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time of pull in the format of `yyyymmddhh` accurate to the hour.
        /// </summary>
        [JsonProperty("StartDateTime")]
        public ulong? StartDateTime{ get; set; }

        /// <summary>
        /// End time of pull in the format of `yyyymmddhh` accurate to the hour
        /// Note: `EndDataTime` must be later than `StartDateTime`.
        /// </summary>
        [JsonProperty("EndDataTime")]
        public ulong? EndDataTime{ get; set; }

        /// <summary>
        /// SMS `SdkAppid` actually generated after an application is added in the [SMS Console](https://console.cloud.tencent.com/sms/smslist), such as 1400006666.
        /// </summary>
        [JsonProperty("SmsSdkAppid")]
        public string SmsSdkAppid{ get; set; }

        /// <summary>
        /// Upper limit.
        /// Note: this parameter is currently fixed at 0.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset.
        /// Note: this parameter is currently fixed at 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartDateTime", this.StartDateTime);
            this.SetParamSimple(map, prefix + "EndDataTime", this.EndDataTime);
            this.SetParamSimple(map, prefix + "SmsSdkAppid", this.SmsSdkAppid);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

