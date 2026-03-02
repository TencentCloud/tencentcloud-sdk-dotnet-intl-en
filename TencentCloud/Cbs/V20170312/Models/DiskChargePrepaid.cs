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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskChargePrepaid : AbstractModel
    {
        
        /// <summary>
        /// Specifies the duration for purchasing cloud block storage (cbs) in months. default unit: month. valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, 36.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Automatic renewal flag. valid values:.
        /// <ul>
        /// <Li>NOTIFY_AND_AUTO_RENEW: notifies expiry and renews automatically.</li>.
        /// <Li>NOTIFY_AND_MANUAL_RENEW: notifies expiry but does not renew automatically.</li>.
        /// <Li>DISABLE_NOTIFY_AND_MANUAL_RENEW: no notification is sent upon expiration, and the instance is not renewed automatically.</li>.
        /// </ul>
        /// Default value: NOTIFY_AND_MANUAL_RENEW.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Specifies the current expiration time of the child machine when the expiration time of the cloud block storage needs to align with the mounted child machine. you can input this parameter. if Period is input at this time, it indicates the duration of child machine renewal. the cloud disk will automatically renew according to the expiration time after the child machine is renewed.
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
            this.SetParamSimple(map, prefix + "CurInstanceDeadline", this.CurInstanceDeadline);
        }
    }
}

