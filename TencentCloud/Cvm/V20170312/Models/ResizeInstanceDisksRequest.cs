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

    public class ResizeInstanceDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID to be operated. can be obtained from the `InstanceId` in the return value from the DescribeInstances api (https://www.tencentcloud.com/document/api/213/15728?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the configuration information of the data disk to be expanded, only supporting specifying the target capacity of the disk to be expanded. only non-elastic data disks (with `Portable` being `false` in the return values of [DescribeDisks](https://www.tencentcloud.com/document/api/362/16315?from_cn_redirect=1)) can be expanded. the unit of data disk capacity is GiB. the minimum expansion step is 10 GiB. for data disk type selection, refer to [disk product introduction](https://www.tencentcloud.com/document/product/362/2353?from_cn_redirect=1). the available data disk type is restricted by the instance type `InstanceType`. additionally, the maximum allowable capacity for expansion varies by data disk type.
        /// <dx-alert infotype="explain" title="">You should specify either DataDisks or SystemDisk, but you cannot specify both at the same time.</dx-alert>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// Specifies whether to forcibly shut down a running instance. it is recommended to manually shut down a running instance first and then expand the instance disk. valid values:<br><li>true: forcibly shut down an instance after a normal shutdown fails.</li><br><li>false: do not forcibly shut down an instance after a normal shutdown fails.</li><br><br>default value: false.<br><br>forced shutdown is equivalent to turning off a physical computer's power switch. forced shutdown may cause data loss or file system corruption and should only be used when a server cannot be shut down normally.
        /// </summary>
        [JsonProperty("ForceStop")]
        public bool? ForceStop{ get; set; }

        /// <summary>
        /// System disk configuration information to be expanded. only supports specifying the purpose capacity of the disk to be expanded. only supports cloud disk expansion.
        /// <dx-alert infotype="explain" title="">You should specify either DataDisks or SystemDisk, but you cannot specify both at the same time.</dx-alert>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// Whether the cloud disk is expanded online.
        /// </summary>
        [JsonProperty("ResizeOnline")]
        public bool? ResizeOnline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamSimple(map, prefix + "ForceStop", this.ForceStop);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamSimple(map, prefix + "ResizeOnline", this.ResizeOnline);
        }
    }
}

