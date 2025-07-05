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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationStatics : AbstractModel
    {
        
        /// <summary>
        /// Queue name
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Application type
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// `SumMemorySeconds` meaning
        /// </summary>
        [JsonProperty("SumMemorySeconds")]
        public long? SumMemorySeconds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SumVCoreSeconds")]
        public long? SumVCoreSeconds{ get; set; }

        /// <summary>
        /// SumHDFSBytesWritten (with unit)
        /// </summary>
        [JsonProperty("SumHDFSBytesWritten")]
        public string SumHDFSBytesWritten{ get; set; }

        /// <summary>
        /// SumHDFSBytesRead (with unit)
        /// </summary>
        [JsonProperty("SumHDFSBytesRead")]
        public string SumHDFSBytesRead{ get; set; }

        /// <summary>
        /// Application count
        /// </summary>
        [JsonProperty("CountApps")]
        public long? CountApps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "SumMemorySeconds", this.SumMemorySeconds);
            this.SetParamSimple(map, prefix + "SumVCoreSeconds", this.SumVCoreSeconds);
            this.SetParamSimple(map, prefix + "SumHDFSBytesWritten", this.SumHDFSBytesWritten);
            this.SetParamSimple(map, prefix + "SumHDFSBytesRead", this.SumHDFSBytesRead);
            this.SetParamSimple(map, prefix + "CountApps", this.CountApps);
        }
    }
}

