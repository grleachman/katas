class Project
  class << self
    def name
      @name = "katas"
    end

    def startup_dir
      @startup_dir = File.join(%w[product katas])
    end

    def specs_dir
      @specs_dir = File.join(%w[artifacts specs])
    end

    def report_folder
      @report_folder = File.join(%w[artifacts specs report]) 
    end

    def spec_assemblies
      @spec_assemblies = Dir.glob(File.join('artifacts',"katas*specs.dll"))
    end

    def startup_config
      @startup_config = "app.config"
    end

    def startup_extension
      @startup_extension = ".dll"
    end
  end
end
