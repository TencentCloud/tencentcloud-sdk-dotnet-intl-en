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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class App : AbstractModel
    {
        
        /// <summary>
        /// <p>Auxiliary information (sub-status/approval/appeal/search for resource/special status)</p>
        /// </summary>
        [JsonProperty("AuxiliaryInfo")]
        public AppAuxiliaryInfo AuxiliaryInfo{ get; set; }

        /// <summary>
        /// <p>Configuration.</p>
        /// </summary>
        [JsonProperty("Config")]
        public AppConfig Config{ get; set; }

        /// <summary>
        /// <p>Metadata</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public AppMetadata Metadata{ get; set; }

        /// <summary>
        /// <p>Application key information</p>
        /// </summary>
        [JsonProperty("SecretInfo")]
        public AppSecretInfo SecretInfo{ get; set; }

        /// <summary>
        /// <p>Sharing link information (including access control)</p>
        /// </summary>
        [JsonProperty("ShareUrlInfo")]
        public AppShareURLInfo ShareUrlInfo{ get; set; }

        /// <summary>
        /// <p>Status.</p>
        /// </summary>
        [JsonProperty("Status")]
        public AppStatusInfo Status{ get; set; }

        /// <summary>
        /// <p>Business shared configuration</p>
        /// </summary>
        [JsonProperty("CorpShareConfig")]
        public CorpShareConfig CorpShareConfig{ get; set; }

        /// <summary>
        /// <p>List of shared knowledge bases referenced by the application</p>
        /// </summary>
        [JsonProperty("SharedKbList")]
        public AppSharedKbInfo[] SharedKbList{ get; set; }

        /// <summary>
        /// <p>portal shared configuration</p>
        /// </summary>
        [JsonProperty("PortalShareConfig")]
        public PortalShareConfig PortalShareConfig{ get; set; }

        /// <summary>
        /// <p>Application-mounted cloud disk</p>
        /// </summary>
        [JsonProperty("FileVolumeMountList")]
        public FileVolumeMount[] FileVolumeMountList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AuxiliaryInfo.", this.AuxiliaryInfo);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamObj(map, prefix + "SecretInfo.", this.SecretInfo);
            this.SetParamObj(map, prefix + "ShareUrlInfo.", this.ShareUrlInfo);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamObj(map, prefix + "CorpShareConfig.", this.CorpShareConfig);
            this.SetParamArrayObj(map, prefix + "SharedKbList.", this.SharedKbList);
            this.SetParamObj(map, prefix + "PortalShareConfig.", this.PortalShareConfig);
            this.SetParamArrayObj(map, prefix + "FileVolumeMountList.", this.FileVolumeMountList);
        }
    }
}

