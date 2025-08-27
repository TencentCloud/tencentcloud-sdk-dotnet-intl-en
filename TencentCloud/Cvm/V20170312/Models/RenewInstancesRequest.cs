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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// One or more instance IDs to be operated. You can obtain the instance ID through the `InstanceId` in the return value from the API [DescribeInstances](https://www.tencentcloud.comom/document/api/213/15728?from_cn_redirect=1). The maximum number of instances per request is 100.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Prepaid mode, that is, parameter settings related to monthly/annual subscription. specifies attributes of a monthly subscription instance, such as renewal duration and whether to enable auto-renewal, by specifying this parameter. <dx-alert infotype="explain" title="">.
        /// Annual and monthly subscription instances. this parameter is a required parameter.</dx-alert>.
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// Whether to renew the elastic data disk. valid values:<br><li>true: indicates renewing the annual and monthly subscription instance and its mounted elastic data disk simultaneously</li><li>false: indicates renewing the annual and monthly subscription instance while no longer renewing its mounted elastic data disk</li><br>default value: true.
        /// </summary>
        [JsonProperty("RenewPortableDataDisk")]
        public bool? RenewPortableDataDisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "RenewPortableDataDisk", this.RenewPortableDataDisk);
        }
    }
}

