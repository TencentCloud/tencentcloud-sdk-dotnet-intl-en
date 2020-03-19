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

    public class PullSmsSendStatus : AbstractModel
    {
        
        /// <summary>
        /// Actual time of SMS receipt by user.
        /// </summary>
        [JsonProperty("UserReceiveTime")]
        public string UserReceiveTime{ get; set; }

        /// <summary>
        /// Actual time of SMS receipt by user in seconds in the format of UNIX timestamp.
        /// </summary>
        [JsonProperty("UserReceiveUnixTime")]
        public ulong? UserReceiveUnixTime{ get; set; }

        /// <summary>
        /// Country (or region) code.
        /// </summary>
        [JsonProperty("NationCode")]
        public string NationCode{ get; set; }

        /// <summary>
        /// Mobile number in the e.164 standard (+[country/region code][mobile number]), such as +8613711112222, which has a + sign followed by 86 (country/region code) and then by 13711112222 (mobile number).
        /// </summary>
        [JsonProperty("PurePhoneNumber")]
        public string PurePhoneNumber{ get; set; }

        /// <summary>
        /// Mobile number in a common format such as 13711112222.
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// ID of the current delivery.
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// Whether the SMS message is actually received. Valid values: SUCCESS (success), FAIL (failure).
        /// </summary>
        [JsonProperty("ReportStatus")]
        public string ReportStatus{ get; set; }

        /// <summary>
        /// Description of SMS receipt by user.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserReceiveTime", this.UserReceiveTime);
            this.SetParamSimple(map, prefix + "UserReceiveUnixTime", this.UserReceiveUnixTime);
            this.SetParamSimple(map, prefix + "NationCode", this.NationCode);
            this.SetParamSimple(map, prefix + "PurePhoneNumber", this.PurePhoneNumber);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "SerialNo", this.SerialNo);
            this.SetParamSimple(map, prefix + "ReportStatus", this.ReportStatus);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

