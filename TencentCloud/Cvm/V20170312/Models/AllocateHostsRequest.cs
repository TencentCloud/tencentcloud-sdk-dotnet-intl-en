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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocateHostsRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance location. This parameter is used to specify the attributes of an instance, such as its availability zone and project.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// A string used to ensure the idempotency of the request.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Configuration of prepaid instances. You can use the parameter to specify the attributes of prepaid instances, such as the subscription period and the auto-renewal plan. This parameter is required for prepaid instances.
        /// </summary>
        [JsonProperty("HostChargePrepaid")]
        public ChargePrepaid HostChargePrepaid{ get; set; }

        /// <summary>
        /// Instance billing model, only monthly or yearly subscription supported. Default value: `PREPAID'.
        /// </summary>
        [JsonProperty("HostChargeType")]
        public string HostChargeType{ get; set; }

        /// <summary>
        /// CDH instance model. Default value: `HS1`.
        /// </summary>
        [JsonProperty("HostType")]
        public string HostType{ get; set; }

        /// <summary>
        /// Quantity of CDH instances purchased. Default value: 1.
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// Tag description. You can specify the parameter to associate a tag with an instance.
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "HostChargePrepaid.", this.HostChargePrepaid);
            this.SetParamSimple(map, prefix + "HostChargeType", this.HostChargeType);
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
        }
    }
}

