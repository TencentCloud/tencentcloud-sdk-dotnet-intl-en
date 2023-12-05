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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewDiskChargePrepaid : AbstractModel
    {
        
        /// <summary>
        /// Renewal period
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Whether to renew the disk automatically. Values:
        /// 
        /// `NOTIFY_AND_AUTO_RENEW`: Trigger expiration notification and renew automatically; `NOTIFY_AND_MANUAL_RENEW`: Trigger expiration notification but do not renew; `DISABLE_NOTIFY_AND_MANUAL_RENEW`: Do not trigger the notification and do not renew.
        /// 
        /// Default: `NOTIFY_AND_MANUAL_RENEW`. If `NOTIFY_AND_AUTO_RENEW` is specified, the instance is automatically renewed on a monthly basis when the account balance is sufficient.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Unit of the period. Values: `m` (month).
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Expiration time of the current instance, such as "2018-01-01 00:00:00". Specify this parameter to align the expiration time of the instance and attached cloud disks. `CurInstanceDeadline` and `Period` cannot be both specified.
        /// </summary>
        [JsonProperty("CurInstanceDeadline")]
        public string CurInstanceDeadline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "CurInstanceDeadline", this.CurInstanceDeadline);
        }
    }
}

