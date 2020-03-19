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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PreExecuteFileSettings : AbstractModel
    {
        
        /// <summary>
        /// COS path to script, which has been disused
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Execution script parameter
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// COS bucket name, which has been disused
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// COS region name, which has been disused
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// COS domain data, which has been disused
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Execution sequence
        /// </summary>
        [JsonProperty("RunOrder")]
        public long? RunOrder{ get; set; }

        /// <summary>
        /// `resourceAfter` or `clusterAfter`
        /// </summary>
        [JsonProperty("WhenRun")]
        public string WhenRun{ get; set; }

        /// <summary>
        /// Script name, which has been disused
        /// </summary>
        [JsonProperty("CosFileName")]
        public string CosFileName{ get; set; }

        /// <summary>
        /// COS address of script
        /// </summary>
        [JsonProperty("CosFileURI")]
        public string CosFileURI{ get; set; }

        /// <summary>
        /// COS `SecretId`
        /// </summary>
        [JsonProperty("CosSecretId")]
        public string CosSecretId{ get; set; }

        /// <summary>
        /// COS `SecretKey`
        /// </summary>
        [JsonProperty("CosSecretKey")]
        public string CosSecretKey{ get; set; }

        /// <summary>
        /// COS `appid`, which has been disused
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "RunOrder", this.RunOrder);
            this.SetParamSimple(map, prefix + "WhenRun", this.WhenRun);
            this.SetParamSimple(map, prefix + "CosFileName", this.CosFileName);
            this.SetParamSimple(map, prefix + "CosFileURI", this.CosFileURI);
            this.SetParamSimple(map, prefix + "CosSecretId", this.CosSecretId);
            this.SetParamSimple(map, prefix + "CosSecretKey", this.CosSecretKey);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

