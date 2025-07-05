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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioFileInfo : AbstractModel
    {
        
        /// <summary>
        /// File id.
        /// </summary>
        [JsonProperty("FileId")]
        public ulong? FileId{ get; set; }

        /// <summary>
        /// File alias.
        /// </summary>
        [JsonProperty("CustomFileName")]
        public string CustomFileName{ get; set; }

        /// <summary>
        /// Filename.
        /// </summary>
        [JsonProperty("AudioFileName")]
        public string AudioFileName{ get; set; }

        /// <summary>
        /// Review status: 0 - unreviewed, 1 - approved, 2 - rejected.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "CustomFileName", this.CustomFileName);
            this.SetParamSimple(map, prefix + "AudioFileName", this.AudioFileName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

