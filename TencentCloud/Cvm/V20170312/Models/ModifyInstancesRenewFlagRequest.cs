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

    public class ModifyInstancesRenewFlagRequest : AbstractModel
    {
        
        /// <summary>
        /// For one or more instance IDs to be operated. You can obtain the instance ID through the `instanceid` in the returned value from the API [DescribeInstances](https://cloud.tencent.com/document/api/213/15728). The maximum number of instances that can be operated for each request is 100.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Auto-renewal flag. Valid values: <br><li>NOTIFY_AND_AUTO_RENEW: Notifies of expiration and performs auto-renewal.</li><li>NOTIFY_AND_MANUAL_RENEW: Notifies of expiration but does not perform auto-renewal.</li><li>DISABLE_NOTIFY_AND_MANUAL_RENEW: Not notifies of expiration nor perform auto-renewal.</li><br>If this parameter is specified to NOTIFY_AND_AUTO_RENEW, the instance will be automatically renewed on a monthly basis after it expires when there is sufficient account balance.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
        }
    }
}

