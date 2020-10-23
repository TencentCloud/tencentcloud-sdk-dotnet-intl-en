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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosFileUploadTrigger : AbstractModel
    {
        
        /// <summary>
        /// Name of the COS bucket bound to a workflow, such as `TopRankVideo-125xxx88`.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// Region of the COS bucket bound to a workflow, such as `ap-chongiqng`.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Input path directory bound to a workflow, such as `/movie/201907/`. If this parameter is left empty, the `/` root directory will be used.
        /// </summary>
        [JsonProperty("Dir")]
        public string Dir{ get; set; }

        /// <summary>
        /// Format list of files that can trigger a workflow, such as ["mp4", "flv", "mov"]. If this parameter is left empty, files in all formats can trigger the workflow.
        /// </summary>
        [JsonProperty("Formats")]
        public string[] Formats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Dir", this.Dir);
            this.SetParamArraySimple(map, prefix + "Formats.", this.Formats);
        }
    }
}

