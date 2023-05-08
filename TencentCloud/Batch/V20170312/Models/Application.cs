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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Application : AbstractModel
    {
        
        /// <summary>
        /// Task execution command
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// Delivery form of the application. Values: `PACKAGE` (package stored in a remote location), `LOCAL` (local computer).
        /// </summary>
        [JsonProperty("DeliveryForm")]
        public string DeliveryForm{ get; set; }

        /// <summary>
        /// Remote storage path of the application package
        /// </summary>
        [JsonProperty("PackagePath")]
        public string PackagePath{ get; set; }

        /// <summary>
        /// Relevant configuration of the Docker used by the application. In case that the Docker configuration is used, "LOCAL" DeliveryForm means that the application software inside the Docker image is used directly and run in Docker mode; "PACKAGE" DeliveryForm means that the remote application package is run in Docker mode after being injected into the Docker image. To avoid compatibility issues with different versions of Docker, the Docker installation package and relevant dependencies are taken care of by BatchCompute. For custom images where Docker has already been installed, uninstall Docker first and then use the Docker feature.
        /// </summary>
        [JsonProperty("Docker")]
        public Docker Docker{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "DeliveryForm", this.DeliveryForm);
            this.SetParamSimple(map, prefix + "PackagePath", this.PackagePath);
            this.SetParamObj(map, prefix + "Docker.", this.Docker);
        }
    }
}

