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

    public class ResetInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of IDs of the instances to be reinstalled.
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// ID of the image from which to install the instance. If this parameter is not specified, the current image of the instance will be used.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Password. If this parameter is not specified, the password will be subsequently displayed in the Message Center.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Whether to enable CM and CWP. If this parameter is not specified, they will be enabled by default.
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// Whether to retain the data on the data disk. Valid values: true, false. Default value: true
        /// </summary>
        [JsonProperty("KeepData")]
        public string KeepData{ get; set; }

        /// <summary>
        /// Whether to keep the original settings for the image. You cannot specify this parameter if `Password` or `KeyIds.N` is specified. You can specify this parameter as `TRUE` only when you create an instance by using a custom image, shared image, or image imported from an external resource. Valid values:
        /// TRUE: yes
        /// FALSE: no
        /// 
        /// Default value: FALSE.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeepImageLogin")]
        public string KeepImageLogin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "KeepData", this.KeepData);
            this.SetParamSimple(map, prefix + "KeepImageLogin", this.KeepImageLogin);
        }
    }
}

