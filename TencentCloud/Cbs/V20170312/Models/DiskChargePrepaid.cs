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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskChargePrepaid : AbstractModel
    {
        
        /// <summary>
        /// Subscription period of the cloud disk in months. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, 36.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Auto-renewal flag. Valid values: <br><li>NOTIFY_AND_AUTO_RENEW: Notify upon expiration and renew automatically <br><li>NOTIFY_AND_MANUAL_RENEW: Notify upon expiration but do not renew automatically <br><li>DISABLE_NOTIFY_AND_MANUAL_RENEW: Neither notify upon expiration nor renew automatically <br><br>Default value: NOTIFY_AND_MANUAL_RENEW.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// You can specify this parameter when you need to ensure that a cloud disk and the CVM instance to which it is attached have the same expiration time. This parameter represents the current expiration time of the instance. In this case, if you specify `Period`, `Period` will represent how long you want to renew the instance, and the cloud disk will be renewed based on the new expiration time of the instance. For example, the value of this parameter can be `2018-03-30 20:15:03`.
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

