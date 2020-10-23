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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Code : AbstractModel
    {
        
        /// <summary>
        /// COS bucket name
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// COS object path
        /// </summary>
        [JsonProperty("CosObjectName")]
        public string CosObjectName{ get; set; }

        /// <summary>
        /// It contains a function code file and its dependencies in the ZIP format. When you use this API, the ZIP file needs to be encoded with Base64. Up to 20 MB is supported.
        /// </summary>
        [JsonProperty("ZipFile")]
        public string ZipFile{ get; set; }

        /// <summary>
        /// COS region. For Beijing regions, you need to import `ap-beijing`. For Beijing Region 1, you need to input `ap-beijing-1`. For other regions, no import is required.
        /// </summary>
        [JsonProperty("CosBucketRegion")]
        public string CosBucketRegion{ get; set; }

        /// <summary>
        /// `DemoId` is required if Demo is used for the creation.
        /// </summary>
        [JsonProperty("DemoId")]
        public string DemoId{ get; set; }

        /// <summary>
        /// `TempCosObjectName` is required if TempCos is used for the creation.
        /// </summary>
        [JsonProperty("TempCosObjectName")]
        public string TempCosObjectName{ get; set; }

        /// <summary>
        /// Git address
        /// </summary>
        [JsonProperty("GitUrl")]
        public string GitUrl{ get; set; }

        /// <summary>
        /// Git user name
        /// </summary>
        [JsonProperty("GitUserName")]
        public string GitUserName{ get; set; }

        /// <summary>
        /// Git password
        /// </summary>
        [JsonProperty("GitPassword")]
        public string GitPassword{ get; set; }

        /// <summary>
        /// Git password after encryption. In general, this value is not required.
        /// </summary>
        [JsonProperty("GitPasswordSecret")]
        public string GitPasswordSecret{ get; set; }

        /// <summary>
        /// Git branch
        /// </summary>
        [JsonProperty("GitBranch")]
        public string GitBranch{ get; set; }

        /// <summary>
        /// Code path in Git repository
        /// </summary>
        [JsonProperty("GitDirectory")]
        public string GitDirectory{ get; set; }

        /// <summary>
        /// Version to be pulled
        /// </summary>
        [JsonProperty("GitCommitId")]
        public string GitCommitId{ get; set; }

        /// <summary>
        /// Git user name after encryption. In general, this value is not required.
        /// </summary>
        [JsonProperty("GitUserNameSecret")]
        public string GitUserNameSecret{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CosObjectName", this.CosObjectName);
            this.SetParamSimple(map, prefix + "ZipFile", this.ZipFile);
            this.SetParamSimple(map, prefix + "CosBucketRegion", this.CosBucketRegion);
            this.SetParamSimple(map, prefix + "DemoId", this.DemoId);
            this.SetParamSimple(map, prefix + "TempCosObjectName", this.TempCosObjectName);
            this.SetParamSimple(map, prefix + "GitUrl", this.GitUrl);
            this.SetParamSimple(map, prefix + "GitUserName", this.GitUserName);
            this.SetParamSimple(map, prefix + "GitPassword", this.GitPassword);
            this.SetParamSimple(map, prefix + "GitPasswordSecret", this.GitPasswordSecret);
            this.SetParamSimple(map, prefix + "GitBranch", this.GitBranch);
            this.SetParamSimple(map, prefix + "GitDirectory", this.GitDirectory);
            this.SetParamSimple(map, prefix + "GitCommitId", this.GitCommitId);
            this.SetParamSimple(map, prefix + "GitUserNameSecret", this.GitUserNameSecret);
        }
    }
}

