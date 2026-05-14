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

    public class UpdateApplicationInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("MpApplicationId")]
        public string MpApplicationId{ get; set; }

        /// <summary>
        /// Application name of the created app
        /// </summary>
        [JsonProperty("MpApplicationName")]
        public string MpApplicationName{ get; set; }

        /// <summary>
        /// Remark of the created device
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Access environment. 0: public cloud gateway; 1: private gateway; 2: public cloud gateway and private gateway. By default if left blank, public cloud gateway is selected. Specific meaning: Public cloud gateway: The device can only connect to public cloud gateway (Proximity access). Private gateway: The device can only connect to already launched private gateway (Proximity access or fixed ip access). Public cloud gateway and private gateway: The device can also connect to both public cloud gateway and already launched private gateway (Proximity access or fixed ip access).
        /// </summary>
        [JsonProperty("AccessScope")]
        public long? AccessScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MpApplicationId", this.MpApplicationId);
            this.SetParamSimple(map, prefix + "MpApplicationName", this.MpApplicationName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
        }
    }
}

