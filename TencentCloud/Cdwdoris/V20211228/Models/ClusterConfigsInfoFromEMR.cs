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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterConfigsInfoFromEMR : AbstractModel
    {
        
        /// <summary>
        /// Configuration file's name
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// Related attribute information corresponding to the configuration files
        /// </summary>
        [JsonProperty("FileConf")]
        public string FileConf{ get; set; }

        /// <summary>
        /// Other attribute information corresponding to the configuration files
        /// </summary>
        [JsonProperty("KeyConf")]
        public string KeyConf{ get; set; }

        /// <summary>
        /// Contents of the configuration files, base64 encoded
        /// </summary>
        [JsonProperty("OriParam")]
        public string OriParam{ get; set; }

        /// <summary>
        /// This is used to indicate whether the current configuration file has been modified without a restart, and reminds the user that a restart is needed.
        /// </summary>
        [JsonProperty("NeedRestart")]
        public long? NeedRestart{ get; set; }

        /// <summary>
        /// Configuration file path
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// kv value of a configuration file
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileKeyValues")]
        [System.Obsolete]
        public string FileKeyValues{ get; set; }

        /// <summary>
        /// kv value of a configuration file
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileKeyValuesNew")]
        public ConfigKeyValue[] FileKeyValuesNew{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileConf", this.FileConf);
            this.SetParamSimple(map, prefix + "KeyConf", this.KeyConf);
            this.SetParamSimple(map, prefix + "OriParam", this.OriParam);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileKeyValues", this.FileKeyValues);
            this.SetParamArrayObj(map, prefix + "FileKeyValuesNew.", this.FileKeyValuesNew);
        }
    }
}

