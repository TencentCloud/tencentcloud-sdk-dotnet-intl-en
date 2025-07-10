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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceChargePrepaid : AbstractModel
    {
        
        /// <summary>
        /// Instance purchase duration. Unit: months. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, and 36. Default value: 1.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Automatic renewal flag. Valid values:
        ///  - NOTIFY_AND_AUTO_RENEW: A notification is sent upon expiration, and the instance is renewed automatically. If the account balance is sufficient, the instance will be renewed automatically on a monthly basis after expiration.
        ///  - NOTIFY_AND_MANUAL_RENEW: A notification is sent upon expiration, but the instance is not renewed automatically. Default value: NOTIFY_AND_MANUAL_RENEW.
        ///  - DISABLE_NOTIFY_AND_MANUAL_RENEW: No notification is sent upon expiration, and the instance is not renewed automatically.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
        }
    }
}

