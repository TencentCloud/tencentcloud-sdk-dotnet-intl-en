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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DockerContainerConfiguration : AbstractModel
    {
        
        /// <summary>
        /// Container image address
        /// </summary>
        [JsonProperty("ContainerImage")]
        public string ContainerImage{ get; set; }

        /// <summary>
        /// Container name
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// List of environment variables
        /// </summary>
        [JsonProperty("Envs")]
        public ContainerEnv[] Envs{ get; set; }

        /// <summary>
        /// List of mappings of container ports and host ports
        /// </summary>
        [JsonProperty("PublishPorts")]
        public DockerContainerPublishPort[] PublishPorts{ get; set; }

        /// <summary>
        /// List of container mount volumes
        /// </summary>
        [JsonProperty("Volumes")]
        public DockerContainerVolume[] Volumes{ get; set; }

        /// <summary>
        /// The command to run
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContainerImage", this.ContainerImage);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "PublishPorts.", this.PublishPorts);
            this.SetParamArrayObj(map, prefix + "Volumes.", this.Volumes);
            this.SetParamSimple(map, prefix + "Command", this.Command);
        }
    }
}

