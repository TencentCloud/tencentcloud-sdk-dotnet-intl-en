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

    public class ResizeInstanceDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. To obtain the instance IDs, you can call [`DescribeInstances`](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1) and look for `InstanceId` in the response.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Configuration information of a data disk to be expanded. Only inelastic data disks (with `Portable` being `false` in the return values of [DescribeDisks](https://intl.cloud.tencent.com/document/api/362/16315?from_cn_redirect=1)) can be expanded. The unit of data disk capacity is GB. The minimum expansion step is 10 GB. For more information about data disk types, refer to [Disk Product Introduction](https://intl.cloud.tencent.com/document/product/362/2353?from_cn_redirect=1). The available data disk type is restricted by the instance type `InstanceType`. Additionally, the maximum allowable capacity for expansion varies by data disk type.
        /// <dx-alert infotype="explain" title="">You should specify either DataDisks or SystemDisk, but you cannot specify both at the same time.</dx-alert>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// Whether to forcibly shut down a running instance. It is recommended to manually shut down a running instance first and then reset the user password. Valid values:<br><li>true: Forcibly shut down an instance after a normal shutdown fails.</li><br><li>false: Do not forcibly shut down an instance after a normal shutdown fails.</li><br><br>Default value: false.<br><br>Forced shutdown is equivalent to turning off a physical computer's power switch. Forced shutdown may cause data loss or file system corruption and should only be used when a server cannot be shut down normally.
        /// </summary>
        [JsonProperty("ForceStop")]
        public bool? ForceStop{ get; set; }

        /// <summary>
        /// Configuration information of a system disk to be expanded. Only cloud disks can be expanded.
        /// 
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

