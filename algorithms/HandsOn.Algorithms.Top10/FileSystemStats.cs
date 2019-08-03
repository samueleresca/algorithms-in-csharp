using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithms.Top10
{
    public class FileSystemStats
    {
        public string solution(string S)
        {
            IInputProcessor fileInputProcessor = new FileInputProcessor();

            List<File> files = fileInputProcessor.Read(S);

            var fileExtMapper = new Dictionary<string, string>
            {
                {"mp3", "music"},
                {"aac", "music"},
                {"flac", "music"},
                {"jpg", "images"},
                {"bmp", "images"},
                {"gif", "images"},
                {"mp4", "movies"},
                {"avi", "movies"},
                {"mkv", "movies"},
            };

            IFileSizeGroupProvider fileSizeGroupProvider =
                new FileExtensionGroupProvider()
                    .SetMapper(fileExtMapper, "other");


            return fileSizeGroupProvider.Group(files);
        }
    }

    public interface IInputProcessor
    {
        List<File> Read(string s);
    }

    public interface IFileSizeGroupProvider
    {
        IFileSizeGroupProvider SetMapper(Dictionary<string, string> mapper, string @default);
        string Group(List<File> files);
    }


    public class FileExtensionGroupProvider : IFileSizeGroupProvider
    {
        private Dictionary<string, string> _mapper;
        private string _defaultCategory;

        public IFileSizeGroupProvider SetMapper(Dictionary<string, string> mapper, string @default)
        {
            _mapper = mapper;
            _defaultCategory = @default;

            return this;
        }

        public string Group(List<File> files)
        {
            if (_mapper == null || _defaultCategory == null)
                throw new ArgumentNullException("You should call SetMapper before");

            var filesgrouped = new Dictionary<string, long>
            {
                {"music", 0},
                {"images", 0},
                {"movies", 0},
                {"other", 0}
            };

            foreach (var file in files)
            {
                filesgrouped = mapAndUpdateGroups(filesgrouped, file);
            }

            return string.Join(Environment.NewLine, filesgrouped.Select(k => $"{k.Key} {k.Value}b").ToList());
        }


        private Dictionary<string, long> mapAndUpdateGroups(Dictionary<string, long> dictionary, File file)
        {

            var group = _mapper.ContainsKey(file.Extension.FileType) ? _mapper[file.Extension.FileType] : _defaultCategory;
            dictionary[group] += file.Size;
            return dictionary;
        }
    }

    public class FileInputProcessor : IInputProcessor
    {
        public List<File> Read(string s)
        {
            string[] lines = s.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var fileList = new List<File>();


            foreach (var line in lines)
            {
                var file = new File();
                string fileCompleteName = line.Split(' ')[0];
                string fileSize = line.Split(' ')[1];

                int extIndex = fileCompleteName.LastIndexOf('.');

                file.Size = long.Parse(fileSize.Trim('b'));
                file.FileName = fileCompleteName.Substring(0, extIndex);
                file.Extension = new Extension { FileType = fileCompleteName.Substring(extIndex + 1) };

                fileList.Add(file);

            }

            return fileList;
        }
    }

    public class File
    {
        public string FileName { get; set; }
        public Extension Extension { get; set; }
        public long Size { get; set; }
    }

    public class Extension
    {
        public string FileType { get; set; }
    }
}