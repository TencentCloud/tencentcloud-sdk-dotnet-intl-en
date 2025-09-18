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

    public class ModifyInstancesChargeTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// One or more instance ids to be operated. you can obtain the instance ID through the `InstanceId` in the return value from the api [DescribeInstances](https://www.tencentcloud.com/document/api/213/15728?from_cn_redirect=1). the maximum number of instances per request is 30.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Modified instance [billing type](https://www.tencentcloud.com/document/product/213/2180?from_cn_redirect=1). <li>`PREPAID`: monthly subscription.</li> 
        /// **Note:** Only supports converting pay-as-you-go instances to annual and monthly subscription instances.
        /// 
        /// default value: `PREPAID`
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Modified prepaid mode, parameter settings related to monthly/annual subscription. by specifying this parameter, you can specify the purchase duration of annual and monthly subscription instances, whether to enable auto-renewal, and other attributes. 
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// Whether to switch the billing mode of elastic data cloud disks simultaneously. valid values: <li> true: means switching the billing mode of elastic data cloud disks</li><li> false: means not switching the billing mode of elastic data cloud disks</li>default value: false.
        /// </summary>
        [JsonProperty("ModifyPortableDataDisk")]
        public bool? ModifyPortableDataDisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "ModifyPortableDataDisk", this.ModifyPortableDataDisk);
        }
    }
}

