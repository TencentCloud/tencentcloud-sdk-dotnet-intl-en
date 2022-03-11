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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisassociateInstancesKeyPairsRequest : AbstractModel
    {
        
        /// <summary>
        /// You can get available instance IDs in the following ways:
        /// Log in to the console to query instance IDs.
        /// Get the instance IDs from the `InstanceId` field in the information returned by the `DescribeInstances` API.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// List of key pair IDs. Each request can contain up to 100 key pairs. The key pair ID takes the form of `skey-11112222`.
        /// 
        /// You can get available key IDs in the following ways:
        /// Log in to the console to query key IDs.
        /// Get the key pair IDs from the `KeyId` field in the information returned by the `DescribeKeyPairs` API.
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }

        /// <summary>
        /// Whether to force shut down the running instance. We recommend you manually shut down the running instance before unbinding the key. Valid values:
        /// TRUE: yes.
        /// FALSE: no.
        /// 
        /// Default value: FALSE.
        /// </summary>
        [JsonProperty("ForceStop")]
        public bool? ForceStop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
            this.SetParamSimple(map, prefix + "ForceStop", this.ForceStop);
        }
    }
}

